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
using System.Collections;
using E_ticaret.Classes;

namespace E_ticaret
{

   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Users girişyapanüye;
        string[] kategorilerdizi = {"","","","","" };
        string[] kategorilabel = new string[5];
        string[,] ürünler = new string[5, 3];
        string[] kargocular = { "", "", "", "", "" };
        string[] tedarikçiler = { "", "", "", "", "" };
        string admin = "admin";
        int sayaçüye = 0;
        int productobject1;
        int productobject2;
        int productobject3;
        int productobject4;
        int productobject5;
        int ürünsayısı = 0;
        bool[] kategoridoldurma = { false, false, false, false, false };
        Hashtable producthash = new Hashtable();

        Users üye1 = new Users();

        Users üye2 = new Users();
        Users üye3 = new Users();
        Users üye4 = new Users();
        Users üye5 = new Users();
        Users üye6 = new Users();
        Users üye7 = new Users();
        Users admins = new Users();
        

        public MainWindow()
        {
            
            InitializeComponent();
            ekranlarıkapama();
            üyegiriş.Visibility = Visibility.Visible;
            
            admins.Username = admin;
            admins.Password = admin;
            
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
            Profilepanel.Visibility = Visibility.Hidden;
            Profileupdatepanel.Visibility = Visibility.Hidden;
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

        #region navbar açma
        public void navbaracma()
        {
            Kategoribtn.Visibility = Visibility.Visible;
            Ürünlerbtn.Visibility = Visibility.Visible;
            Sepetbtn.Visibility = Visibility.Visible;
            Homebtn.Visibility = Visibility.Visible;
            anasayfastack.Visibility = Visibility.Visible;
        }
        #endregion
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
            ürünlerigösterme();

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
        private void üyeolbtns_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Üye_ekranı.Visibility=Visibility.Visible;
        }


        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ekranlarıkapama();
            Profilepanel.Visibility = Visibility.Visible;
            profileheader.Content = ($"{girişyapanüye.Username} profilinize hoşgeldiniz" );
            profile1.Content = ($"Ad : {girişyapanüye.NAME}");
            profile2.Content = ($"Soyad : {girişyapanüye.SURNAME}");
            profile3.Content = ($"Doğum Tarihi : {girişyapanüye.DATE}");
            profile4.Content = ($"Adres : {girişyapanüye.ADRESS}");
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
                
                try
                {
                   if(admins.giriş(kullanıcıtxt.Text,şifretxt.Text) == true)
                   {
                    ekranlarıkapama();
                    Admincheck.IsChecked = true;
                    navbaracma();
                   }

                   else if(üye1.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                   {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma();
                    Profile.Visibility = Visibility.Visible;
                }
                else if (üye2.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                else if (üye3.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                else if (üye4.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                else if (üye5.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                else if (üye6.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                if (üye7.giriş(kullanıcıtxt.Text, şifretxt.Text) == true)
                {
                    ekranlarıkapama();
                    Admincheck.IsChecked = false;
                    navbaracma(); Profile.Visibility = Visibility.Visible;
                }
                }
                catch (Exception ex)
                {
                    hatalılbl.Content = ex.Message;

                }



            
        }

        #endregion
        #region Üye olma

        private void Üyeolbtn_Click(object sender, RoutedEventArgs e)
        {
            
            switch (sayaçüye)
            {
                case 0:
                    try
                    {
                        
                        üye1.Username = üyeekletxt.Text;
                        üye1.Password = üyeşiftetxt.Text; Üye_ekranı.Visibility = Visibility.Hidden;
                        sayaçüye++;
                        girişyapanüye = üye1;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    
                    break;
                case 1:
                    try
                    {
                        
                        üye2.Username = üyeekletxt.Text;
                        üye2.Password = üyeşiftetxt.Text;
                        sayaçüye++; Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye2;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    
                    break;
                case 2:
                    try
                    {
                        üye3.Username = üyeekletxt.Text;
                        üye3.Password = üyeşiftetxt.Text;
                        sayaçüye++; Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye3;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    
                    break;
                case 3:
                    try
                    {

                        üye4.Username = üyeekletxt.Text;
                        üye4.Password = üyeşiftetxt.Text;
                        sayaçüye++; Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye4;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    break;
                case 4:
                    try
                    {
                        üye5.Username = üyeekletxt.Text;
                        üye5.Password = üyeşiftetxt.Text;
                        sayaçüye++; Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye5;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    break;
                case 5:
                    try
                    {
                        üye6.Username = üyeekletxt.Text;
                        üye6.Password = üyeşiftetxt.Text;
                        sayaçüye++; Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye6;
                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                    
                    break;
                case 6:
                    try
                    {
                        üye7.Username = üyeekletxt.Text;
                        üye7.Password = üyeşiftetxt.Text;
                        sayaçüye++;
                        Üye_ekranı.Visibility = Visibility.Hidden;
                        girişyapanüye = üye7;

                    }
                    catch (Exception ex)
                    {

                        hatalılbl1.Content = ex.Message;
                    }
                   
                    break;
                default:
                    hatalılbl1.Content = "Azami üye limitine gelinmiştir.";
                    break;

            }

            üyegiriş.Visibility = Visibility.Visible;
        }
        #endregion
        #region Ürün ekleme
        private void Ürünekleme_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (var item in producthash)
            {
               
                for (int i = 0; i < producthash.Count; i++)
                {
                    ürünsayısı++;
                }
            }
            if(ürünsayısı == 0)
            {
                Ürünclass ürün1 = new Ürünclass(yeniürünisim.Text, yeniürünfiyat.Text, ürünlerinkategori.SelectedItem.ToString(), ürünsayısı);
                producthash.Add(ürün1.ID, ürün1);
                productobject1 = ürün1.ID;
            }
            else if(ürünsayısı == 1)
            {
                Ürünclass ürün2 = new Ürünclass(yeniürünisim.Text, yeniürünfiyat.Text, ürünlerinkategori.SelectedItem.ToString(), ürünsayısı);
                producthash.Add(ürün2.ID, ürün2);
                productobject2 = ürün2.ID;
            }
            else if (ürünsayısı == 2)
            {
                Ürünclass ürün3 = new Ürünclass(yeniürünisim.Text, yeniürünfiyat.Text, ürünlerinkategori.SelectedItem.ToString(), ürünsayısı);
                producthash.Add(ürün3.ID, ürün3);
                productobject3 = ürün3.ID;
            }
            else if (ürünsayısı == 3)
            {
                Ürünclass ürün4 = new Ürünclass(yeniürünisim.Text, yeniürünfiyat.Text, ürünlerinkategori.SelectedItem.ToString(), ürünsayısı);
                producthash.Add(ürün4.ID, ürün4);
                productobject4 = ürün4.ID;
            }
            else if (ürünsayısı == 4)
            {
                Ürünclass ürün5 = new Ürünclass(yeniürünisim.Text, yeniürünfiyat.Text, ürünlerinkategori.SelectedItem.ToString(), ürünsayısı);
                producthash.Add(ürün5.ID, ürün5);
                productobject5 = ürün5.ID;
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

        public void kategorigöster(int categorindex)
        {
            Ürünclass product1 = (Ürünclass)producthash[0];
            Ürünclass product2 = (Ürünclass)producthash[1];
            Ürünclass product3 = (Ürünclass)producthash[2];
            Ürünclass product4 = (Ürünclass)producthash[3];
            Ürünclass product5 = (Ürünclass)producthash[4];
            kategorikapa();
            if (product1.PRODUCTCATEGORY != null && product1.PRODUCTCATEGORY == kategorilerdizi[categorindex])
            {
                for(int i = 0; i < 5; i++)
                {
                    if (kategoridoldurma[i] == false)
                    {
                        switch (i)
                        {
                            case 0:
                                ürünkisim1.Content =  product1.PRODUCTNAME;
                                ürünkfiyat1.Content = product1.PRODUCTPRİCE;
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 1:
                                ürünkisim2.Content =  product1.PRODUCTNAME;
                                ürünkfiyat2.Content = product1.PRODUCTPRİCE;
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 2:
                                ürünkisim3.Content =  product1.PRODUCTNAME;
                                ürünkfiyat3.Content = product1.PRODUCTPRİCE;
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 3:
                                ürünkisim4.Content =  product1.PRODUCTNAME;
                                ürünkfiyat4.Content = product1.PRODUCTPRİCE;
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 4:
                                ürünkisim5.Content =  product1.PRODUCTNAME;
                                ürünkfiyat5.Content = product1.PRODUCTPRİCE;
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (kategoridoldurma[i] == true) break;
                }
            }
            if (product2.PRODUCTCATEGORY != null && product2.PRODUCTCATEGORY == kategorilerdizi[categorindex])
            {
                for (int i = 0; i < 5; i++)
                {
                    if (kategoridoldurma[i] == false)
                    {
                        switch (i)
                        {
                            case 0:
                                ürünkisim1.Content =  product2.PRODUCTNAME;
                                ürünkfiyat1.Content = product2.PRODUCTPRİCE;
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 1:
                                ürünkisim2.Content =  product2.PRODUCTNAME;
                                ürünkfiyat2.Content = product2.PRODUCTPRİCE;
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 2:
                                ürünkisim3.Content =  product2.PRODUCTNAME;
                                ürünkfiyat3.Content = product2.PRODUCTPRİCE;
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 3:
                                ürünkisim4.Content =  product2.PRODUCTNAME;
                                ürünkfiyat4.Content = product2.PRODUCTPRİCE;
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 4:
                                ürünkisim5.Content =  product2.PRODUCTNAME;
                                ürünkfiyat5.Content = product2.PRODUCTPRİCE;
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (kategoridoldurma[i] == true) break;
                }
            }
            if (product3.PRODUCTCATEGORY != null && product3.PRODUCTCATEGORY == kategorilerdizi[categorindex])
            {
                for (int i = 0; i < 5; i++)
                {
                    if (kategoridoldurma[i] == false)
                    {
                        switch (i)
                        {
                            case 0:
                                ürünkisim1.Content =  product3.PRODUCTNAME;
                                ürünkfiyat1.Content = product3.PRODUCTPRİCE;
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 1:
                                ürünkisim2.Content =  product3.PRODUCTNAME;
                                ürünkfiyat2.Content = product3.PRODUCTPRİCE;
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 2:
                                ürünkisim3.Content =  product3.PRODUCTNAME;
                                ürünkfiyat3.Content = product3.PRODUCTPRİCE;
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 3:
                                ürünkisim4.Content =  product3.PRODUCTNAME;
                                ürünkfiyat4.Content = product3.PRODUCTPRİCE;
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 4:
                                ürünkisim5.Content =  product3.PRODUCTNAME;
                                ürünkfiyat5.Content = product3.PRODUCTPRİCE;
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (kategoridoldurma[i] == true) break;
                }
            }
            if (product4.PRODUCTCATEGORY != null && product4.PRODUCTCATEGORY == kategorilerdizi[categorindex])
            {
                for (int i = 0; i < 5; i++)
                {
                    if (kategoridoldurma[i] == false)
                    {
                        switch (i)
                        {
                            case 0:
                                ürünkisim1.Content =  product4.PRODUCTNAME;
                                ürünkfiyat1.Content = product4.PRODUCTPRİCE;
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 1:
                                ürünkisim2.Content =  product4.PRODUCTNAME;
                                ürünkfiyat2.Content = product4.PRODUCTPRİCE;
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 2:
                                ürünkisim3.Content =  product4.PRODUCTNAME;
                                ürünkfiyat3.Content = product4.PRODUCTPRİCE;
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 3:
                                ürünkisim4.Content =  product4.PRODUCTNAME;
                                ürünkfiyat4.Content = product4.PRODUCTPRİCE;
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 4:
                                ürünkisim5.Content =  product4.PRODUCTNAME;
                                ürünkfiyat5.Content = product4.PRODUCTPRİCE;
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (kategoridoldurma[i] == true) break;
                }
            }
            if (product5.PRODUCTCATEGORY != null && product5.PRODUCTCATEGORY == kategorilerdizi[categorindex])
            {
                for (int i = 0; i < 5; i++)
                {
                    if (kategoridoldurma[i] == false)
                    {
                        switch (i)
                        {
                            case 0:
                                ürünkisim1.Content =  product5.PRODUCTNAME;
                                ürünkfiyat1.Content = product5.PRODUCTPRİCE;
                                ürünkisim1.Visibility = Visibility.Visible;
                                ürünkfiyat1.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 1:
                                ürünkisim2.Content =  product5.PRODUCTNAME;
                                ürünkfiyat2.Content = product5.PRODUCTPRİCE;
                                ürünkisim2.Visibility = Visibility.Visible;
                                ürünkfiyat2.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 2:
                                ürünkisim3.Content =  product5.PRODUCTNAME;
                                ürünkfiyat3.Content = product5.PRODUCTPRİCE;
                                ürünkisim3.Visibility = Visibility.Visible;
                                ürünkfiyat3.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 3:
                                ürünkisim4.Content =  product5.PRODUCTNAME;
                                ürünkfiyat4.Content = product5.PRODUCTPRİCE;
                                ürünkisim4.Visibility = Visibility.Visible;
                                ürünkfiyat4.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            case 4:
                                ürünkisim5.Content =  product5.PRODUCTNAME;
                                ürünkfiyat5.Content = product5.PRODUCTPRİCE;
                                ürünkisim5.Visibility = Visibility.Visible;
                                ürünkfiyat5.Visibility = Visibility.Visible;
                                kategoridoldurma[i] = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (kategoridoldurma[i] == true) break;
                }
            }
        }
            
        
        public void kategorikapa()
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
        }
        private void kategorigöster1_Click(object sender, RoutedEventArgs e)
        {
            kategorikapa();

            kategorigöster(0);
        }
        private void kategorigöster2_Click(object sender, RoutedEventArgs e)
        {
            kategorikapa();
            kategorigöster(1);
            
        }
        private void kategorigöster3_Click(object sender, RoutedEventArgs e)
        {
            kategorikapa();
            kategorigöster(2);

        }
        private void kategorigöster4_Click(object sender, RoutedEventArgs e)
        {
            kategorikapa();
            kategorigöster(3);
        }
        
        private void kategorigöster5_Click(object sender, RoutedEventArgs e)
        {
            kategorikapa();
            kategorigöster(4);
        
            
        }
        #endregion
        #region ürün göster
        public void ürünlerigösterme()
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (producthash[i] != null)
                {
                    Ürünclass product1 = (Ürünclass)producthash[i];
                    switch (i) 
                    {
                        case 0:
                        ürünbirisim.Content = product1.PRODUCTNAME;
                        ürünbirfiyat.Content = product1.PRODUCTPRİCE;
                        ürünbirkategori.Content = product1.PRODUCTCATEGORY;
                        ürünbir.Visibility = Visibility.Visible;
                        ürünbirisim.Visibility = Visibility.Visible;
                        ürünbirfiyat.Visibility = Visibility.Visible;
                        ürünbirkategori.Visibility = Visibility.Visible;
                            break;
                        case 1:
                            ürünikiisim.Content = product1.PRODUCTNAME;
                            ürünikifiyat.Content = product1.PRODUCTPRİCE;
                            ürünikikategori.Content = product1.PRODUCTCATEGORY;
                            ürüniki.Visibility = Visibility.Visible;
                            ürünikiisim.Visibility = Visibility.Visible;
                            ürünikifiyat.Visibility = Visibility.Visible;
                            ürünikikategori.Visibility = Visibility.Visible;
                            break;
                        case 2:
                            ürünüçisim.Content = product1.PRODUCTNAME;
                            ürünüçfiyat.Content = product1.PRODUCTPRİCE;
                            ürünüçkategori.Content = product1.PRODUCTCATEGORY;
                            ürünüç.Visibility = Visibility.Visible;
                            ürünüçisim.Visibility = Visibility.Visible;
                            ürünüçfiyat.Visibility = Visibility.Visible;
                            ürünüçkategori.Visibility = Visibility.Visible;
                            break;
                        case 3:
                            üründörtisim.Content = product1.PRODUCTNAME;
                            üründörtfiyat.Content = product1.PRODUCTPRİCE;
                            üründörtkategori.Content = product1.PRODUCTCATEGORY;
                            üründört.Visibility = Visibility.Visible;
                            üründörtisim.Visibility = Visibility.Visible;
                            üründörtfiyat.Visibility = Visibility.Visible;
                            üründörtkategori.Visibility = Visibility.Visible;
                            break;
                        case 4:
                            ürünbeşisim.Content = product1.PRODUCTNAME;
                            ürünbeşfiyat.Content = product1.PRODUCTPRİCE;
                            ürünbeşkategori.Content = product1.PRODUCTCATEGORY;
                            ürünbeş.Visibility = Visibility.Visible;
                            ürünbeşisim.Visibility = Visibility.Visible;
                            ürünbeşfiyat.Visibility = Visibility.Visible;
                            ürünbeşkategori.Visibility = Visibility.Visible;
                            break;
                        default:
                            break;
                    }
                    
                }

            }


        }
        #endregion
        #region Üye bilgisi güncelleme

        private void üyeupdpanelbtn_Click(object sender, RoutedEventArgs e)
        {
            Profileupdatepanel.Visibility = Visibility.Visible;
            üyeyeniad.Visibility = Visibility.Visible;
            üyeyenisoyad.Visibility = Visibility.Visible;
        }
        private void üyebilgiupd_Click(object sender, RoutedEventArgs e)
        {
            girişyapanüye.NAME = üyeyeniad.Text;
            girişyapanüye.SURNAME = üyeyenisoyad.Text;
            girişyapanüye.DATE = üyeyenidogum.DisplayDate.ToString();
            girişyapanüye.ADRESS = üyeyeniadres.Text;
            Profileupdatepanel.Visibility = Visibility.Hidden;
            üyeyeniad.Visibility= Visibility.Hidden;
            üyeyenisoyad.Visibility = Visibility.Hidden;
            profile1.Content = ($"Ad : {girişyapanüye.NAME}");
            profile2.Content = ($"Soyad : {girişyapanüye.SURNAME}");
            profile3.Content = ($"Doğum Tarihi : {girişyapanüye.DATE}");
            profile4.Content = ($"Adres : {girişyapanüye.ADRESS}");
        }
        #endregion

        #endregion

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }
}
