using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E_ticaret
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string[] kategorilerdizi = {"","","","","" };
        string[] kategorilabel = new string[5];
        string[,] ürünler = new string[5, 3];
        string[] kargocular = { "", "", "", "", "" };
        string[] tedarikçiler = { "", "", "", "", "" };
        

        public MainWindow()
        {
            
            InitializeComponent();
            ekranlarıkapama();
            üyegiriş.Visibility = Visibility.Visible;
        }
        #region Admin check

        private void Admincheck_Checked(object sender, RoutedEventArgs e)
        {
            Tedarikçibtn.Visibility = Visibility.Visible;
            kategorieklebtn.Visibility = Visibility.Visible;
            urunekle.Visibility = Visibility.Visible;
            Kargoeklebtn.Visibility = Visibility.Visible;
            
        }
       

        private void Admincheck_Unchecked_1(object sender, RoutedEventArgs e)
        {
            Tedarikçibtn.Visibility = Visibility.Hidden;
            kategorieklebtn.Visibility = Visibility.Hidden;
            urunekle.Visibility = Visibility.Hidden;
            Kargoeklebtn.Visibility = Visibility.Hidden;
        }
        #endregion
        #region Ana ekrana dönme işlemi
        void ekranlarıkapama()
        {
            Kategoriler.Visibility = Visibility.Hidden;
            anasayfastack.Visibility = Visibility.Hidden;
            Ürünler.Visibility = Visibility.Hidden;
            Sepet.Visibility = Visibility.Hidden;
            Tedarikçiekle.Visibility = Visibility.Hidden;
            Kategoriekle.Visibility = Visibility.Hidden;
            Kargocuekle.Visibility = Visibility.Hidden;
            Ürünekle.Visibility = Visibility.Hidden;
            üyegiriş.Visibility = Visibility.Hidden;
            ürünbir.Visibility = Visibility.Hidden;
            ürüniki.Visibility = Visibility.Hidden;
            ürünüç.Visibility = Visibility.Hidden;
            üründört.Visibility = Visibility.Hidden;
            ürünbeş.Visibility = Visibility.Hidden;
        }
        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            anasayfastack.Visibility=Visibility.Visible;
        }
        #endregion
        //Ürünler sayfasaında gösterilen itemler ürünlerbtn ile ekleniyor 
        //Nav barın içinde
        #region Navbar

        private void Kategoribtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Kategoriler.Visibility = Visibility.Visible;
            if (kategorilerdizi[0] != "" ) {kategorigöster1.Visibility = Visibility.Visible; kategorigöster1.Content = kategorilerdizi[0]; }
            if (kategorilerdizi[1] != "" ) {kategorigöster2.Visibility = Visibility.Visible; kategorigöster2.Content = kategorilerdizi[1]; }
            if (kategorilerdizi[2] != "" ) {kategorigöster3.Visibility = Visibility.Visible; kategorigöster3.Content = kategorilerdizi[2]; }
            if (kategorilerdizi[3] != "" ) {kategorigöster4.Visibility = Visibility.Visible; kategorigöster4.Content = kategorilerdizi[3]; }
            if (kategorilerdizi[4] != "") { kategorigöster5.Visibility = Visibility.Visible; kategorigöster5.Content = kategorilerdizi[4]; }
        }

        private void Ürünlerbtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Ürünler.Visibility = Visibility.Visible;
            for (int i = 0; i < 5; i++)
            {
                if(ürünler[i,0] != null)
                {
                    switch (i)
                    {
                        case 0:
                            ürünbirisim.Content = ürünler[i, 0];
                            ürünbirfiyat.Content = ürünler[i, 1];
                            ürünbirkategori.Content = ürünler[i, 2];
                            ürünbir.Visibility = Visibility.Visible;
                        break;
                        case 1:
                            ürünikiisim.Content = ürünler[i, 0];
                            ürünikifiyat.Content = ürünler[i, 1];
                            ürünikikategori.Content = ürünler[i, 2];
                            ürüniki.Visibility = Visibility.Visible;
                            break;
                        case 2:
                            ürünüçisim.Content = ürünler[i, 0];
                            ürünüçfiyat.Content = ürünler[i, 1];
                            ürünüçkategori.Content = ürünler[i, 2];
                            ürünüç.Visibility = Visibility.Visible;
                            break;
                        case 3:
                            üründörtisim.Content = ürünler[i, 0];
                            üründörtfiyat.Content = ürünler[i, 1];
                            üründörtkategori.Content = ürünler[i, 2];
                            üründört.Visibility = Visibility.Visible;
                            break;
                        case 4:
                            ürünbeşisim.Content = ürünler[i, 0];
                            ürünbeşfiyat.Content = ürünler[i, 1];
                            ürünbeşkategori.Content = ürünler[i, 2];
                            ürünbeş.Visibility = Visibility.Visible;
                            break;
                    }
                }
            }
        }

        private void Sepetbtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Sepet.Visibility = Visibility.Visible;
        }

        private void Tedarikçibtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Tedarikçiekle.Visibility = Visibility.Visible;
        }

        private void kategorieklebtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
           
            Kategoriekle.Visibility = Visibility.Visible;
        }

        private void urunekle_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Ürünekle.Visibility = Visibility.Visible;
        }
        private void Kargoeklebtn_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Kargocuekle.Visibility = Visibility.Visible;
        }

        #endregion

        #region Sayfalar
        #region kategoriekleme
        //5 elemanlı bir array oluşturdum uygulamaya maksimim 5 tane kategori eklenebilecek

        //TODO
        //Sayaç ekle sona gelince uyarı versin
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool eklendi = false;
            for (int i = 0; i < kategorilerdizi.Length; i++)
            {
                if (kategorilerdizi[i] == "" && eklendi == false)
                {
                    kategorilerdizi[i] = kategorieklemetxt.Text;
                    ürünlerinkategori.Items.Add(kategorilerdizi[i]);
                    break;
                    
                }
            }
            kategori1.Content = kategorilerdizi[0];
            kategori2.Content = kategorilerdizi[1];
            kategori3.Content = kategorilerdizi[2];
            kategori4.Content = kategorilerdizi[3];
            kategori5.Content = kategorilerdizi[4];
            kategorieklemetxt.Clear();
        }

        

        #endregion
        #region Kategori silme

        private void kategorisil1_Click(object sender, RoutedEventArgs e)
        {
            ürünlerinkategori.Items.Remove(kategorilerdizi[0]);
            kategorilerdizi[0] = "";
            kategori1.Content =  "";
        }

        private void kategorisil2_Click(object sender, RoutedEventArgs e)
        {
            ürünlerinkategori.Items.Remove(kategorilerdizi[1]);
            kategorilerdizi[1] = "";
            kategori2.Content =  "";
        }

        private void kategorisil3_Click(object sender, RoutedEventArgs e)
        {
            ürünlerinkategori.Items.Remove(kategorilerdizi[2]);
            kategorilerdizi[2] = "";
            kategori3.Content =  "";
        }

        private void kategorisil4_Click(object sender, RoutedEventArgs e)
        {
            ürünlerinkategori.Items.Remove(kategorilerdizi[3]);
            kategorilerdizi[3] = "";
            kategori4.Content =  "";
        }

        private void kategorisil5_Click(object sender, RoutedEventArgs e)
        {
            ürünlerinkategori.Items.Remove(kategorilerdizi[4]);
            kategorilerdizi[4] = "";
            kategori5.Content =  "";
        }

        #endregion
        #region giriş yapma

        private void girişyapbtn_Click(object sender, RoutedEventArgs e)
        {
            string admin = "admin";
            if(kullanıcıtxt.Text == admin && şifretxt.Text == admin)
            {
                try
                {
                    Users users = new Users();
                    users.Username = admin;
                    users.Password = admin;
                    Admincheck.IsChecked = true;
                    Ürünlerbtn.Visibility = Visibility.Visible;
                    Homebtn.Visibility = Visibility.Visible;
                    Kategoribtn.Visibility = Visibility.Visible;
                    Sepetbtn.Visibility = Visibility.Visible;
                    ekranlarıkapama();
                    anasayfastack.Visibility = Visibility.Visible;
                }
                catch (Exception ex)
                {
                    hatalılbl.Content = ex.Message;

                }
            }
            else if (kullanıcıtxt.Text == admin && şifretxt.Text != admin)
            {
                hatalılbl.Content = "Hatalı şifre girdiniz.";
            }
            else
            {
                try
                {
                    Users users = new Users();
                    users.Username = kullanıcıtxt.Text;
                    users.Password = şifretxt.Text;
                    Admincheck.IsChecked = true;
                    Ürünlerbtn.Visibility = Visibility.Visible;
                    Homebtn.Visibility = Visibility.Visible;
                    Kategoribtn.Visibility = Visibility.Visible;
                    Sepetbtn.Visibility = Visibility.Visible;
                    ekranlarıkapama();
                    anasayfastack.Visibility = Visibility.Visible;
                }
                catch (Exception ex)
                {
                    hatalılbl.Content = ex.Message;

                }
            }
        }

        #endregion
        #region Ürün ekleme
        private void Ürünekleme_Click(object sender, RoutedEventArgs e)
        {
            bool eklendi = false;
            for (int i = 0; i < 5; i++)
            {
                if (ürünler[i,0] == null && ürünler[i,1] == null && ürünler[i,2] == null && eklendi == false && yeniürünfiyat.Text != "" && yeniürünisim.Text != "")
                {
                    ürünler[i, 0] = yeniürünisim.Text;
                    ürünler[i, 1] = yeniürünfiyat.Text;
                    ürünler[i, 2]=  ürünlerinkategori.SelectedValue.ToString();
                    eklendi = true;
                }
            }
            yeniürünfiyat.Text = "";
            yeniürünisim.Text = "";
        }

        #endregion
        #region Tedarikçi ekleme
        private void tedarikçiekleme_Click(object sender, RoutedEventArgs e)
        {
            bool eklendi = false;
            for (int i = 0; i < tedarikçiler.Length; i++)
            {
                if (tedarikçiler[i] == "" && eklendi == false)
                {
                    tedarikçiler[i] = tedarikçieklemetxt.Text;
                    break;

                }
            }
            tedarikçibir.Content = tedarikçiler[0];
            tedarikçiiki.Content = tedarikçiler[1];
            tedarikçiüç.Content =  tedarikçiler[2];
            tedarikçidört.Content =tedarikçiler[3];
            tedarikçibeş.Content = tedarikçiler[4];
            tedarikçieklemetxt.Clear();
        }
        #endregion
        #region Tedarikçi Silme
        private void ted1_Click(object sender, RoutedEventArgs e)
        {
            tedarikçiler[0] = "";
            tedarikçibir.Content = "";
        }

        private void ted2_Click(object sender, RoutedEventArgs e)
        {
            tedarikçiler[1] = "";
            tedarikçiiki.Content = "";
        }

        private void ted3_Click(object sender, RoutedEventArgs e)
        {
            tedarikçiler[2] = "";
            tedarikçiüç.Content = "";
        }

        private void ted4_Click(object sender, RoutedEventArgs e)
        {
            tedarikçiler[3] = "";
            tedarikçidört.Content = "";
        }

        private void ted5_Click(object sender, RoutedEventArgs e)
        {
            tedarikçiler[4] = "";
            tedarikçibeş.Content = "";
        }


        #endregion
        #region Kargocu ekleme
        private void kargocuekleme_Click(object sender, RoutedEventArgs e)
        {
            bool eklendi = false;
            for (int i = 0; i < kargocular.Length; i++)
            {
                if (kargocular[i] == "" && eklendi == false)
                {
                    kargocular[i] = kargocueklemetxt.Text;
                    break;

                }
            }
            karg1.Content = kargocular[0];
            karg2.Content = kargocular[1];
            karg3.Content =  kargocular[2];
            karg4.Content =kargocular[3];
            karg5.Content = kargocular[4];
            tedarikçieklemetxt.Clear();
        }
        #endregion
        #region Kargocu silme
        private void kar1_Click(object sender, RoutedEventArgs e)
        {
            kargocular[0] = "";
            karg1.Content = "";
        }

        private void kar2_Click(object sender, RoutedEventArgs e)
        {
            kargocular[1] = "";
            karg2.Content = "";
        }

        private void kar3_Click(object sender, RoutedEventArgs e)
        {
            kargocular[2] = "";
            karg3.Content = "";
        }

        private void kar4_Click(object sender, RoutedEventArgs e)
        {
            kargocular[3] = "";
            karg4.Content = "";
        }

        private void kar5_Click(object sender, RoutedEventArgs e)
        {
            kargocular[4] = "";
            karg5.Content = "";
        }
        #endregion
        #region Kategoriler sayfası
        private void kategorigöster1_Click(object sender, RoutedEventArgs e)
        {
             ürünkisim1.Visibility = Visibility.Hidden;
            ürünkfiyat1.Visibility = Visibility.Hidden;
             ürünkisim2.Visibility = Visibility.Hidden;
            ürünkfiyat2.Visibility = Visibility.Hidden;
             ürünkisim3.Visibility = Visibility.Hidden;
            ürünkfiyat3.Visibility = Visibility.Hidden;
             ürünkisim4.Visibility = Visibility.Hidden;
            ürünkfiyat4.Visibility = Visibility.Hidden;
             ürünkisim5.Visibility = Visibility.Hidden;
            ürünkfiyat5.Visibility = Visibility.Hidden;
            int sayaç = 0;
            for (int i = 0; i < 5; i++)
            {
               
                if (ürünler[i,2] != null) 
                { 
                if (ürünler[i, 2] == kategorilerdizi[0])
                {

                    switch (sayaç)
                    {
                        case 0:
                            sayaç++;
                            ürünkisim1.Content = ürünler[i, 0];
                            ürünkfiyat1.Content = ürünler[i, 1];
                             ürünkisim1.Visibility = Visibility.Visible;
                            ürünkfiyat1.Visibility = Visibility.Visible;
                            break;
                        case 1:
                            sayaç++;
                            ürünkisim2.Content = ürünler[i, 0];
                            ürünkfiyat2.Content = ürünler[i, 1];
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                break;
                        case 2:
                            sayaç++;
                            ürünkisim3.Content = ürünler[i, 0];
                            ürünkfiyat3.Content = ürünler[i, 1];
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                break;
                        case 3:
                            sayaç++;
                            ürünkisim4.Content = ürünler[i, 0];
                            ürünkfiyat4.Content = ürünler[i, 1];
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                break;
                        case 4:
                            sayaç++;
                            ürünkisim5.Content = ürünler[i, 0];
                            ürünkfiyat5.Content = ürünler[i, 1];
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                break;
                        default:
                            break;
                        }
                    }
                }
            }
        }
        private void kategorigöster2_Click(object sender, RoutedEventArgs e)
        {
            ürünkisim1.Visibility = Visibility.Hidden;
            ürünkfiyat1.Visibility = Visibility.Hidden;
            ürünkisim2.Visibility = Visibility.Hidden;
            ürünkfiyat2.Visibility = Visibility.Hidden;
            ürünkisim3.Visibility = Visibility.Hidden;
            ürünkfiyat3.Visibility = Visibility.Hidden;
            ürünkisim4.Visibility = Visibility.Hidden;
            ürünkfiyat4.Visibility = Visibility.Hidden;
            ürünkisim5.Visibility = Visibility.Hidden;
            ürünkfiyat5.Visibility = Visibility.Hidden;
            int sayaç = 0;
            for (int i = 0; i < 5; i++)
            {

                if (ürünler[i, 2] != null)
                {
                    if (ürünler[i, 2] == kategorilerdizi[1])
                    {

                        switch (sayaç)
                        {
                            case 0:
                                sayaç++;
                                ürünkisim1.Content = ürünler[i, 0];
                                ürünkfiyat1.Content = ürünler[i, 1];
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                break;
                            case 1:
                                sayaç++;
                                ürünkisim2.Content = ürünler[i, 0];
                                ürünkfiyat2.Content = ürünler[i, 1];
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                break;
                            case 2:
                                sayaç++;
                                ürünkisim3.Content = ürünler[i, 0];
                                ürünkfiyat3.Content = ürünler[i, 1];
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                break;
                            case 3:
                                sayaç++;
                                ürünkisim4.Content = ürünler[i, 0];
                                ürünkfiyat4.Content = ürünler[i, 1];
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                break;
                            case 4:
                                sayaç++;
                                ürünkisim5.Content = ürünler[i, 0];
                                ürünkfiyat5.Content = ürünler[i, 1];
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void kategorigöster3_Click(object sender, RoutedEventArgs e)
        {
            ürünkisim1.Visibility = Visibility.Hidden;
            ürünkfiyat1.Visibility = Visibility.Hidden;
            ürünkisim2.Visibility = Visibility.Hidden;
            ürünkfiyat2.Visibility = Visibility.Hidden;
            ürünkisim3.Visibility = Visibility.Hidden;
            ürünkfiyat3.Visibility = Visibility.Hidden;
            ürünkisim4.Visibility = Visibility.Hidden;
            ürünkfiyat4.Visibility = Visibility.Hidden;
            ürünkisim5.Visibility = Visibility.Hidden;
            ürünkfiyat5.Visibility = Visibility.Hidden;
            int sayaç = 0;
            for (int i = 0; i < 5; i++)
            {

                if (ürünler[i, 2] != null)
                {
                    if (ürünler[i, 2] == kategorilerdizi[2])
                    {

                        switch (sayaç)
                        {
                            case 0:
                                sayaç++;
                                ürünkisim1.Content = ürünler[i, 0];
                                ürünkfiyat1.Content = ürünler[i, 1];
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                break;
                            case 1:
                                sayaç++;
                                ürünkisim2.Content = ürünler[i, 0];
                                ürünkfiyat2.Content = ürünler[i, 1];
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                break;
                            case 2:
                                sayaç++;
                                ürünkisim3.Content = ürünler[i, 0];
                                ürünkfiyat3.Content = ürünler[i, 1];
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                break;
                            case 3:
                                sayaç++;
                                ürünkisim4.Content = ürünler[i, 0];
                                ürünkfiyat4.Content = ürünler[i, 1];
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                break;
                            case 4:
                                sayaç++;
                                ürünkisim5.Content = ürünler[i, 0];
                                ürünkfiyat5.Content = ürünler[i, 1];
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void kategorigöster4_Click(object sender, RoutedEventArgs e)
        {
            ürünkisim1.Visibility = Visibility.Hidden;
            ürünkfiyat1.Visibility = Visibility.Hidden;
            ürünkisim2.Visibility = Visibility.Hidden;
            ürünkfiyat2.Visibility = Visibility.Hidden;
            ürünkisim3.Visibility = Visibility.Hidden;
            ürünkfiyat3.Visibility = Visibility.Hidden;
            ürünkisim4.Visibility = Visibility.Hidden;
            ürünkfiyat4.Visibility = Visibility.Hidden;
            ürünkisim5.Visibility = Visibility.Hidden;
            ürünkfiyat5.Visibility = Visibility.Hidden;
            int sayaç = 0;
            for (int i = 0; i < 5; i++)
            {

                if (ürünler[i, 2] != null)
                {
                    if (ürünler[i, 2] == kategorilerdizi[3])
                    {

                        switch (sayaç)
                        {
                            case 0:
                                sayaç++;
                                ürünkisim1.Content = ürünler[i, 0];
                                ürünkfiyat1.Content = ürünler[i, 1];
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                break;
                            case 1:
                                sayaç++;
                                ürünkisim2.Content = ürünler[i, 0];
                                ürünkfiyat2.Content = ürünler[i, 1];
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                break;
                            case 2:
                                sayaç++;
                                ürünkisim3.Content = ürünler[i, 0];
                                ürünkfiyat3.Content = ürünler[i, 1];
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                break;
                            case 3:
                                sayaç++;
                                ürünkisim4.Content = ürünler[i, 0];
                                ürünkfiyat4.Content = ürünler[i, 1];
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                break;
                            case 4:
                                sayaç++;
                                ürünkisim5.Content = ürünler[i, 0];
                                ürünkfiyat5.Content = ürünler[i, 1];
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void kategorigöster5_Click(object sender, RoutedEventArgs e)
        {
            ürünkisim1.Visibility = Visibility.Hidden;
            ürünkfiyat1.Visibility = Visibility.Hidden;
            ürünkisim2.Visibility = Visibility.Hidden;
            ürünkfiyat2.Visibility = Visibility.Hidden;
            ürünkisim3.Visibility = Visibility.Hidden;
            ürünkfiyat3.Visibility = Visibility.Hidden;
            ürünkisim4.Visibility = Visibility.Hidden;
            ürünkfiyat4.Visibility = Visibility.Hidden;
            ürünkisim5.Visibility = Visibility.Hidden;
            ürünkfiyat5.Visibility = Visibility.Hidden;
            int sayaç = 0;
            for (int i = 0; i < 5; i++)
            {

                if (ürünler[i, 2] != null)
                {
                    if (ürünler[i, 2] == kategorilerdizi[4])
                    {

                        switch (sayaç)
                        {
                            case 0:
                                sayaç++;
                                ürünkisim1.Content = ürünler[i, 0];
                                ürünkfiyat1.Content = ürünler[i, 1];
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                break;
                            case 1:
                                sayaç++;
                                ürünkisim2.Content = ürünler[i, 0];
                                ürünkfiyat2.Content = ürünler[i, 1];
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                break;
                            case 2:
                                sayaç++;
                                ürünkisim3.Content = ürünler[i, 0];
                                ürünkfiyat3.Content = ürünler[i, 1];
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                break;
                            case 3:
                                sayaç++;
                                ürünkisim4.Content = ürünler[i, 0];
                                ürünkfiyat4.Content = ürünler[i, 1];
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                break;
                            case 4:
                                sayaç++;
                                ürünkisim5.Content = ürünler[i, 0];
                                ürünkfiyat5.Content = ürünler[i, 1];
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        #endregion
        #endregion
        private void kategori1_Initialized(object sender, EventArgs e)
        {

        }


    }
}
