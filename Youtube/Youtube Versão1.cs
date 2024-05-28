using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Youtube
{
    public partial class frYoutube : Form
    {
        private YoutubeClient youtube;

        public frYoutube()
        {
            InitializeComponent();
            CmbQualidade.Text = "Selecione a Qualidade";
            youtube = new YoutubeClient();
        }

        // Método Load do formulário
        private void Form1_Load(object sender, EventArgs e)
        {
            // Qualquer inicialização adicional pode ser feita aqui
        }

        // Este método agora é assíncrono para lidar com operações de rede
        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            string videoUrl = txtUrl.Text;
            if (string.IsNullOrWhiteSpace(videoUrl))
            {
                MessageBox.Show("Por favor, insira uma URL do YouTube.");
                return;
            }

            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);

                // Verifica qual o formato selecionado
                if (rdMp3.Checked)
                {
                    // Mostra as opções de áudio
                    var audioStreams = streamManifest.GetAudioOnlyStreams();
                    PopulateAudioQualidadeComboBox(audioStreams);
                }
                else if (rdMp4.Checked)
                {
                    // Mostra as opções de vídeo
                    var videoStreams = streamManifest.GetMuxedStreams();
                    PopulateVideoQualidadeComboBox(videoStreams);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione MP3 ou MP4.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private void PopulateAudioQualidadeComboBox(IEnumerable<AudioOnlyStreamInfo> streams)
        {
            CmbQualidade.Items.Clear();
            foreach (var stream in streams)
            {
                // Formatação para mostrar 4 casas decimais na taxa de bits
                CmbQualidade.Items.Add($"{stream.Bitrate.KiloBitsPerSecond.ToString("F4")} kbps (MP3)");
            }
            if (CmbQualidade.Items.Count > 0)
            {
                CmbQualidade.SelectedIndex = 0;
            }
        }

        private void PopulateVideoQualidadeComboBox(IEnumerable<MuxedStreamInfo> streams)
        {
            CmbQualidade.Items.Clear();
            foreach (var stream in streams)
            {
                double sizeInMb = ConvertBytesToMegabytes(stream.Size.Bytes);
                CmbQualidade.Items.Add($"{stream.VideoQuality.Label} ({sizeInMb:F2} MB)");
            }
            if (CmbQualidade.Items.Count > 0)
            {
                CmbQualidade.SelectedIndex = 0;
            }
        }

        private double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Criar uma instância do SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configurar filtros para MP3 e MP4
                saveFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|MP4 files (*.mp4)|*.mp4";
                saveFileDialog.Title = "Salvar como MP3 ou MP4";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); // Diretório inicial

                // Mostrar o diálogo e verificar o resultado
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Atribuir o caminho do arquivo escolhido ao campo de texto
                    txtCaminho.Text = saveFileDialog.FileName;
                }
                MessageBox.Show("Seu arquivo Foi Guardado com sucesso !..","Guardar", 
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtUrl.Text;
            string savePath = txtCaminho.Text;

            if (string.IsNullOrWhiteSpace(videoUrl))
            {
                MessageBox.Show("Por favor, insira uma URL do YouTube.");
                return;
            }

            if (string.IsNullOrWhiteSpace(savePath))
            {
                MessageBox.Show("Por favor, selecione um local para salvar o arquivo.");
                return;
            }

            try
            {
                var videoId = YoutubeExplode.Videos.VideoId.Parse(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);

                if (rdMp3.Checked)
                {
                    var audioStream = streamManifest.GetAudioOnlyStreams()
                                                     .OrderByDescending(s => s.Bitrate)
                                                     .FirstOrDefault();

                    if (audioStream != null)
                    {
                        var progressHandler = new Progress<double>(progress =>
                        {
                            Avanco.Value = (int)progress;
                        });

                        await youtube.Videos.Streams.DownloadAsync(audioStream, savePath, progressHandler);
                        MessageBox.Show("Download de áudio concluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar uma stream de áudio.");
                    }
                }
                else if (rdMp4.Checked)
                {
                    var selectedVideoQuality = CmbQualidade.SelectedItem.ToString().Split('(')[0].Trim();
                    var videoStream = streamManifest.GetMuxedStreams()
                                                    .Where(s => s.VideoQuality.Label == selectedVideoQuality)
                                                    .FirstOrDefault();

                    if (videoStream != null)
                    {
                        var progressHandler = new Progress<double>(progress =>
                        {
                            Avanco.Value = (int)progress;
                        });

                        await youtube.Videos.Streams.DownloadAsync(videoStream, savePath, progressHandler);
                        MessageBox.Show("Download de vídeo concluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar uma stream de vídeo com a qualidade selecionada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione MP3 ou MP4.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao baixar o vídeo: {ex.Message}");
            }
            finally
            {
                // Resetar a barra de progresso
                Avanco.Value = 100;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtUrl.Text = string.Empty;
            txtCaminho.Text = string.Empty;
            Avanco.Value = 0;
            CmbQualidade.Items.Clear();
            CmbQualidade.Text = "Selecione a Qualidade";
            rdMp3.Checked = false;
            rdMp4.Checked = false;
            MessageBox.Show("Dados Limpos Com sucesso!..", "Limpar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void Fechar()
        {
            if (MessageBox.Show("Deseja sair do Programa?...","Sair",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            this.Close();
        }
        private void rdMp3_CheckedChanged(object sender, EventArgs e)
        {
            CmbQualidade.Items.Clear();
            CmbQualidade.Text = "Selecione a Qualidade";
        }

        private void rdMp4_CheckedChanged(object sender, EventArgs e)
        {
            CmbQualidade.Items.Clear();
            CmbQualidade.Text = "Selecione a Qualidade";
        }
    }
}
