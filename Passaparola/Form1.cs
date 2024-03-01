using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) // e harfi klavyeden herhangi bir tuşla atama yapmak için gerekli olan komut
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    // Cevap 1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 8
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 10
                    case 10:
                        if (textBox1.Text == "içel")   //???????
                        {
                            buttonİ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")   
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")   
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 13
                    case 13:
                        if (textBox1.Text == "lale festivali")   
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 14
                    case 14:
                        if (textBox1.Text == "mart")   
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                    // Cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";     // Başla butonunun cevapla olabilmesi için yapılır.
            soruNo++;
            this.Text = soruNo.ToString();   //Formun solt üst köşesi

            if (soruNo == 1)
            {
                button25.Text = "A";
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ?";
                buttonA.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                button25.Text = "B";
                textBox1.Clear();
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz ?";
                buttonB.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                button25.Text = "C";
                textBox1.Clear();
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                buttonC.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                button25.Text = "D";
                textBox1.Clear();
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz ?";
                buttonD.BackColor = Color.Yellow;
            }

            if (soruNo == 5)
            {
                button25.Text = "E";
                textBox1.Clear();
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                buttonE.BackColor = Color.Yellow;
            }

            if (soruNo == 6)
            {
                button25.Text = "F";
                textBox1.Clear();
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                buttonF.BackColor = Color.Yellow;
            }

            if (soruNo == 7)
            {
                button25.Text = "G";
                textBox1.Clear();
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                buttonG.BackColor = Color.Yellow;
            }

            if (soruNo == 8)
            {
                button25.Text = "H";
                textBox1.Clear();
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne ?";
                buttonH.BackColor = Color.Yellow;
            }

            if (soruNo == 9)
            {
                button25.Text = "I";
                textBox1.Clear();
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                buttonI.BackColor = Color.Yellow;
            }

            if (soruNo == 10)
            {
                button25.Text = "İ";
                textBox1.Clear();
                richTextBox1.Text = "Mersi'nin diğer ismi ?";
                buttonİ.BackColor = Color.Yellow;
            }

            if (soruNo == 11)
            {
                button25.Text = "J";
                textBox1.Clear();
                richTextBox1.Text = "Askeri bir topluluk ?";
                buttonJ.BackColor = Color.Yellow;
            }

            if (soruNo == 12)
            {
                button25.Text = "K";
                textBox1.Clear();
                richTextBox1.Text = "Malatya'nın meşhur meyvesi ?";
                buttonK.BackColor = Color.Yellow;
            }

            if (soruNo == 13)
            {
                button25.Text = "L";
                textBox1.Clear();
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali ?";
                buttonL.BackColor = Color.Yellow;
            }

            if (soruNo == 14)
            {
                button25.Text = "M";
                textBox1.Clear();
                richTextBox1.Text = "Yılın 3. ayı ?";
                buttonM.BackColor = Color.Yellow;
            }

            if (soruNo == 15)
            {
                button25.Text = "N";
                textBox1.Clear();
                richTextBox1.Text = "Üflemeli bir müzik aleti ?";
                buttonN.BackColor = Color.Yellow;
            }

            if (soruNo == 16)
            {
                button25.Text = "O";
                textBox1.Clear();
                richTextBox1.Text = "Halk şairi ?";
                buttonO.BackColor = Color.Yellow;
            }

            if (soruNo == 17)
            {
                button25.Text = "P";
                textBox1.Clear();
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzeler ile yapılan yemek ?";
                buttonP.BackColor = Color.Yellow;
            }

            if (soruNo == 18)
            {
                button25.Text = "R";
                textBox1.Clear();
                richTextBox1.Text = "11 ayın sultanı ?";
                buttonR.BackColor = Color.Yellow;
            }

            if (soruNo == 19)
            {
                button25.Text = "S";
                textBox1.Clear();
                richTextBox1.Text = "Yılan kelimesinin ingilizce karşılığı ?";
                buttonS.BackColor = Color.Yellow;
            }

            if (soruNo == 20)
            {
                button25.Text = "T";
                textBox1.Clear();
                richTextBox1.Text = "Türkiye'nin megastarı ?";
                buttonT.BackColor = Color.Yellow;
            }

            if (soruNo == 21)
            {
                button25.Text = "U";
                textBox1.Clear();
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                buttonU.BackColor = Color.Yellow;
            }

            if (soruNo == 22)
            {
                button25.Text = "V";
                textBox1.Clear();
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                buttonV.BackColor = Color.Yellow;
            }

            if (soruNo == 23)
            {
                button25.Text = "Y";
                textBox1.Clear();
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı ?";
                buttonY.BackColor = Color.Yellow;
            }

            if (soruNo == 24)
            {
                button25.Text = "Z";
                textBox1.Clear();
                richTextBox1.Text = "Ağırlıklı olarak Ege bölgesinde yetişen, yağının yapıldığı kahvaltı besini ?";
                buttonZ.BackColor = Color.Yellow;
            }
        }
    }
}
