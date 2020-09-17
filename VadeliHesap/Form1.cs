using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VadeliHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Müşterinin son iletişim süresi (duraiton) 1531.5 sn'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (DialogResult.Yes == MessageBox.Show("Müşterinin son iletişim süresi (duraiton) 772.5 sn'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (DialogResult.Yes == MessageBox.Show("Müşterinin son iletişim süresi (duraiton) 645 sn'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLMAYACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Önceki bir kampanyadan müşteriyle en son iletişim kurulduktan sonra geçen gün sayısı (pDays) 122'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLMAYACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Müşterinin ortalama yıllık bakiyesi (balance) -909.5'dan küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLMAYACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Müşterinin son iletişim süresi (duraiton) 1518.5 sn'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLMAYACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Son iletişime geçilme dahil bu kampanya sırasında müşteriyle iletişime geçilme sayısı (campaign) 2.5'dan küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (DialogResult.Yes == MessageBox.Show("Müşterinin son iletişim süresi (duraiton) 1730.5 sn'den küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Müşterinin yaşı 43.5'dan küçük ya da eşit mi?", "Müşteri Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLMAYACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLACAK.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("TAHMİN SONUCU : Müşteri vadeli para yatırma işlemine abone OLACAK.");
                }
            }
        }

        public bool TahminEt(Musteri musteri)
        {
            if (musteri.duration <= 1531.5f)
            {
                if (musteri.duration <= 772.5f)
                {
                    if (musteri.duration <= 645)
                    {
                        return false;
                    }
                    else
                    {
                        if (musteri.previousDays <= 122.5f)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (musteri.balance <= 909.5f)
                    {
                        return false;
                    }
                    else
                    {
                        if (musteri.duration <= 1518.5f)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (musteri.campaign <= 2.5f)
                {
                    if (musteri.duration <= 1730.5f)
                    {
                        return true;
                    }
                    else
                    {
                        if (musteri.age <= 43.5f)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        public struct Musteri
        {
            private enum Job
            {
                admin, unknown, unemployed, management, housemaid, entrepreneur, student, blueCollar, selfEmployed, retired, technician, services
            }

            private enum Marital
            {
                married, divorced, single
            }

            private enum Education
            {
                secondary, primary, tertiary
            }

            private enum Month
            {
                Ocak, Subat, Mart, Nisan, Mayis, Haziran, Temmuz, Agustos, Eylul, Ekim, Kasim, Aralik
            }

            private enum PreviousOutcome
            {
                admin, unknown, unemployed, management, housemaid, entrepreneur, student, blueCollar, selfEmployed, retired, technician, services
            }

            public int age, balance, day, duration, campaign, previousDays, previous;

            public bool deflt, housing, loan;
        }
    }
}