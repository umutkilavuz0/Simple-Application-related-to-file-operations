using System.Security.Cryptography;
using System.Text;

namespace FileApplication
{
    public partial class Form1 : Form
    {
        string dosyayol;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string dosyaYol = txtpath.Text;

            if (dosyayol != null)
            {
                reada.Text = File.ReadAllText(dosyayol, new UTF8Encoding(false));
            }
            else
            {
                MessageBox.Show("Yol Hatalı veya Bulunamadı");

            }

        }

        private void btnFileChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog read = new OpenFileDialog
            {
                Title = "Bir dosya seç",
                Filter = "Metinler|*.txt;*.csv;*.json;*.xml|Tümü|*.*"
            }
            )

                if (read.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtpath.Text = read.FileName;
                        dosyayol = txtpath.Text;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Seçme hatası: " + ex.Message);



                    }




                }
        }



        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog
            {
                Title = "Yeni dosya oluştur",
                Filter = "Metin Dosyaları|*.txt|CSV Dosyaları|*.csv|JSON Dosyaları|*.json|XML Dosyaları|*.xml|Tüm Dosyalar|*.*"
            })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dosya oluştur ve içine RichTextBox'taki metni yaz
                        File.WriteAllText(save.FileName, "");

                        // TextBox'a yeni yolu yaz
                        txtpath.Text = save.FileName;
                        dosyayol = save.FileName;

                        MessageBox.Show("Yeni dosya başarıyla oluşturuldu ✅");
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya oluşturma hatası: " + ex.Message);
                    }

                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYol = txtpath.Text;

                if (!File.Exists(dosyaYol))
                {
                    MessageBox.Show("Geçerli bir dosya seçilmedi ❌");
                    return;
                }

                // FileInfo ile bilgileri al
                FileInfo info = new FileInfo(dosyaYol);

                // Bilgileri string olarak hazırla
                string bilgi =
                    $" Dosya Adı: {info.Name}\n" +
                    $" Klasör: {info.DirectoryName}\n" +
                    $" Uzantı: {info.Extension}\n" +
                    $" Boyut: {info.Length / 1024.0:F2} KB\n" +
                    $" Oluşturulma Tarihi: {info.CreationTime}\n" +
                    $" Son Değiştirilme: {info.LastWriteTime}\n" +
                    $" Son Erişim: {info.LastAccessTime}";

                MessageBox.Show(bilgi, "Dosya Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgi alınırken hata oluştu: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYol = txtpath.Text;

                if (File.Exists(dosyayol))
                {
                    DialogResult cevap = MessageBox.Show(
                    "Bu dosyayı silmek istediğine emin misin?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );


                    if (cevap == DialogResult.Yes)

                        File.Delete(dosyayol); // dosyayı siler
                    txtpath.Clear();  // textbox'ı temizle
                    reada.Clear();      // richtextbox'ı temizle
                    MessageBox.Show("Dosya başarıyla silindi ✅");
                }
                else
                {
                    MessageBox.Show("Bu dosya bulunamadı ❌");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
        bool tasiniyor = false;
        Point position;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tasiniyor = true;
            position = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tasiniyor)
            {
                this.Location = new Point(
                    this.Left - position.X + e.X,
                    this.Top - position.Y + e.Y
                    );

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tasiniyor = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
