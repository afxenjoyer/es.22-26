using System;
using System.ComponentModel.DataAnnotations;

namespace es._22_26
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] numeri = {"3", "00", "10", "12", "20", "21", "22", "50", "100", "150", "200", "121", "333",
                "321", "1000", "2000", "1234", "2234", "10000", "12234", "100000", "150000", "101234",  "1000123", "1000234", "2000000"};

            foreach (string numero in numeri)
            {
                lstConversioni.Items.Add(ConvertiNumero(numero));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstConversioni.Items.Clear();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string numeroConvertito = ConvertiNumero(txtInput.Text);
                if (numeroConvertito != "ERRORE")
                {
                    lstConversioni.Items.Add(numeroConvertito);
                }
                else
                {
                    MessageBox.Show("L'input inserito non è un numero",
                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConverti_Click(object sender, EventArgs e)
        {
            string numeroConvertito = ConvertiNumero(txtInput.Text);
            if (numeroConvertito != "ERRORE")
            {
                lstConversioni.Items.Add(numeroConvertito);
            }
            else
            {
                MessageBox.Show("L'input inserito non è un numero",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ContaCifre(int num)
        {
            char[] numDaConvertire = num.ToString().ToCharArray();
            return numDaConvertire.Length;
        }

        string ConvertiNumero(string testo)
        {
            if (int.TryParse(testo, out int num))
            {
                int numCifre = ContaCifre(num);
                char[] numDaConvertire = num.ToString().ToCharArray();
                string risultato = string.Empty;
                
                switch (numCifre)
                {
                    case 1:
                        risultato = ConvertiNumeroSingolaCifra(numDaConvertire[0]);
                        break;
                    case 2:
                        risultato = ConvertiNumeroDueCifre(numDaConvertire);
                        break;
                    case 3:
                        risultato = ConvertiNumeroTreCifre(numDaConvertire);
                        break;
                    case 4:
                        risultato = ConvertiNumeroQuattroCifre(numDaConvertire);
                        break;
                    case 5:
                        risultato = ConvertiNumeroCinqueCifre(numDaConvertire);
                        break;
                    case 6:
                        risultato = ConvertiNumeroSeiCifre(numDaConvertire);
                        break;
                    case 7:
                        risultato = ConvertiNumeroSetteCifre(numDaConvertire);
                        break;
                }
                return risultato;
            }
            else
            {
                return "ERRORE";
            }
        }

        string ConvertiNumeroSingolaCifra(char num)
        {
            switch (num)
            {
                case '0': return "Zero";
                case '1': return "Uno";
                case '2': return "Due";
                case '3': return "Tre";
                case '4': return "Quattro";
                case '5': return "Cinque";
                case '6': return "Sei";
                case '7': return "Sette";
                case '8': return "Otto";
                case '9': return "Nove";
                default: return "ERRORE";
            }
        }

        string ConvertiNumeroDueCifre(char[] num)
        {
            switch (num[0])
            {
                case '1':
                    switch (num[1])
                    {
                        case '0': return "Dieci";
                        case '1': return "Undici";
                        case '2': return "Dodici";
                        case '3': return "Tredici";
                        case '4': return "Quattrordici";
                        case '5': return "Qundici";
                        case '6': return "Sedici";
                        case '7': return "Diciasette";
                        case '8': return "Diciotto";
                        case '9': return "Diciannove";
                        default: return "ERRORE";
                    }
                case '2':
                    switch (num[1])
                    {
                        case '0':
                            return "Venti";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Venti" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Vent" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '3':
                    switch (num[1])
                    {
                        case '0':
                            return "Trenta";
                        case '2': case '3': case '4': 
                        case '5': case '6': case '7': case '9':
                            return "Trenta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Trent" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '4':
                    switch (num[1])
                    {
                        case '0':
                            return "Quaranta";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Quaranta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Quarant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '5':
                    switch (num[1])
                    {
                        case '0':
                            return "Cinquanta";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Cinquanta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Cinquant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '6':
                    switch (num[1])
                    {
                        case '0':
                            return "Sessanta";
                        case '2': case '3': case '4': 
                        case '5': case '6': case '7': case '9':
                            return "Sessanta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Sessant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '7':
                    switch (num[1])
                    {
                        case '0':
                            return "Settanta";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Settanta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Settant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '8':
                    switch (num[1])
                    {
                        case '0':
                            return "Ottanta";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Ottanta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Ottant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '9':
                    switch (num[1])
                    {
                        case '0':
                            return "Novanta";
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return "Novanta" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return "Novant" + ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                case '0':
                    switch (num[1])
                    {
                        case '2': case '3': case '4':
                        case '5': case '6': case '7': case '9':
                            return ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        case '1': case '8':
                            return ConvertiNumeroSingolaCifra(num[1]).ToLower();
                        default: return "ERRORE";
                    }
                default: return "ERRORE";
            }
        }

        string ConvertiNumeroTreCifre(char[] num)
        {
            char[] ultimeDueCifre = new char[2];
            Array.Copy(num, 1, ultimeDueCifre, 0, 2);
            switch (num[0])
            {
                case '1':
                    if (ultimeDueCifre[0] == '0' && ultimeDueCifre[1] == '0')
                    {
                        return "Cento";
                    }
                    else
                    {
                        return "Cento" + ConvertiNumeroDueCifre(ultimeDueCifre).ToLower();
                    }
                case '2': case '3': case '4': case '5':
                case '6': case '7': case '8': case '9':
                    if (ultimeDueCifre[0] == '0' && ultimeDueCifre[1] == '0')
                    {
                        return ConvertiNumeroSingolaCifra(num[0]) + "cento";
                    }
                    else
                    {
                        return ConvertiNumeroSingolaCifra(num[0]) + "cento" + ConvertiNumeroDueCifre(ultimeDueCifre).ToLower();
                    }
                default: return "ERRORE";
            }
        }

        string ConvertiNumeroQuattroCifre(char[] num)
        {
            char[] ultimeTreCifre = new char[3];
            Array.Copy(num, 1, ultimeTreCifre, 0, 3);
            if (num[0] == '1' && num[1] == '0' && num[2] == '0' && num[3] == '0')
            {
                return "Mille";
            }
            else if (num[1] == '0' && num[2] == '0' && num[3] == '0')
            {
                return ConvertiNumeroSingolaCifra(num[0]) + "mila";
            }
            switch (num[0])
            {
                case '1':
                    return "Mille" + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
                case '2': case '3': case '4': case '5':
                case '6': case '7': case '8': case '9':
                    return ConvertiNumeroSingolaCifra(num[0]) + "mila" + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
                default: return "ERRORE";
            }
        }

        string ConvertiNumeroCinqueCifre(char[] num)
        {
            char[] primeDueCifre = new char[2];
            Array.Copy(num, 0, primeDueCifre, 0, 2);

            char[] ultimeTreCifre = new char[3];
            Array.Copy(num, 2, ultimeTreCifre, 0, 3);

            if (ultimeTreCifre[0] == '0' && ultimeTreCifre[1] == '0' && ultimeTreCifre[2] == '0')
            {
                return ConvertiNumeroDueCifre(primeDueCifre) + "mila";
            }

            string risultato = ConvertiNumeroDueCifre(primeDueCifre) + "mila" 
                           + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
            return risultato;
        }

        string ConvertiNumeroSeiCifre(char[] num)
        {
            char[] primeTreCifre = new char[3];
            Array.Copy(num, 0, primeTreCifre, 0, 3);

            char[] ultimeTreCifre = new char[3];
            Array.Copy(num, 3, ultimeTreCifre, 0, 3);

            if (ultimeTreCifre[0] == '0' && ultimeTreCifre[1] == '0' && ultimeTreCifre[2] == '0')
            {
                return ConvertiNumeroTreCifre(primeTreCifre) + "mila";
            }

            string risultato = ConvertiNumeroTreCifre(primeTreCifre) + "mila"
                           + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
            return risultato;
        }

        string ConvertiNumeroSetteCifre(char[] num)
        {
            char[] mezzoTreCifre = new char[3];
            Array.Copy(num, 1, mezzoTreCifre, 0, 3);

            char[] ultimeSeiCifre = new char[6];
            Array.Copy(num, 1, ultimeSeiCifre, 0, 6);

            char[] ultimeTreCifre = new char[3];
            Array.Copy(num, 3, ultimeTreCifre, 0, 3);

            switch (num[0]) 
            {
                case '1':
                    if (num[1] == '0' && num[2] == '0' && num[3] == '0' && num[4] == '0' && num[5] == '0' &&
                        num[6] == '0')
                    {
                        return "Unmilione";
                    }
                    else if (mezzoTreCifre[0] == 0 && mezzoTreCifre[1] == 0 && mezzoTreCifre[2] == 0)
                    {
                        return "Unmilione" + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
                    }
                    else
                    {
                        return "Unmilione" + ConvertiNumeroSeiCifre(ultimeSeiCifre).ToLower();
                    }
                case '2': case '3': case '4': case '5':
                case '6': case '7': case '8': case '9':
                    if (num[1] == '0' && num[2] == '0' && num[3] == '0' && num[4] == '0' && num[5] == '0' &&
                        num[6] == '0')
                    {
                        return ConvertiNumeroSingolaCifra(num[0]) + "milioni";
                    }
                    else if (mezzoTreCifre[0] == 0 && mezzoTreCifre[1] == 0 && mezzoTreCifre[2] == 0)
                    {
                        return ConvertiNumeroSingolaCifra(num[0]) + "milioni" + ConvertiNumeroTreCifre(ultimeTreCifre).ToLower();
                    }
                    else
                    {
                        return ConvertiNumeroSingolaCifra(num[0]) + "milioni" + ConvertiNumeroSeiCifre(ultimeSeiCifre).ToLower();
                    }
                default:
                    return "ERRORE";
            }
        }
    }
}
