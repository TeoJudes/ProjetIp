using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Procédure qui affiche les propriétés de l'ip saisie
        public void afficheParam(ref int cidr)
        {
            if (cidr > 24)//on effectue une condition imbriqué car l'affichage des caractéristique de l'ip changeras en fonction du CIDR
            {
                lbMasque.Text = "Masque : 255.255.255." + masqueReseau(cidr);
                lbReseau.Text = "Adresse Reseau : " + tbIP1.Text + "." + tbIP2.Text + "." + tbIP3.Text + "." + ipReseau(Convert.ToInt16(tbIP4.Text), cidr);
                lbDiffusion.Text = "Adresse de diffusion : " + tbIP1.Text + "." + tbIP2.Text + "." + tbIP3.Text + "." + ipDiffusion(Convert.ToInt16(tbIP4.Text), cidr);
                lbPlage.Text = "Plage d'adresse : " +  tbIP1.Text + "." + tbIP2.Text + "." + tbIP3.Text + "." + (Convert.ToInt16(ipReseau(Convert.ToInt16(tbIP4.Text), cidr))+1).ToString()//continue a la ligne suivante
                + " --> " + tbIP1.Text + "." + tbIP2.Text + "." + tbIP3.Text + "." + (Convert.ToInt16(ipDiffusion(Convert.ToInt16(tbIP4.Text), cidr)) - 1).ToString();
                lbHote.Text = "Nombre d'hotes : " + Convert.ToString(Math.Pow(2, (32 - cidr)) - 2);
            }
            else
            {
                if (cidr > 16)
                {
                    lbMasque.Text = "Masque : 255.255." + masqueReseau(cidr) + ".0";
                    lbReseau.Text = "Adresse Reseau : " + tbIP1.Text + "." + tbIP2.Text + "." + ipReseau(Convert.ToInt16(tbIP3.Text), cidr) + ".0";
                    lbDiffusion.Text = "Adresse de diffusion : " + tbIP1.Text + "." + tbIP2.Text + "." + ipDiffusion(Convert.ToInt16(tbIP3.Text), cidr) + ".255";
                    lbPlage.Text = "Plage d'adresse : " + tbIP1.Text + "." + tbIP2.Text + "." + ipReseau(Convert.ToInt16(tbIP3.Text), cidr) + ".1" //continue sur la ligne suivante
                    + " --> " + tbIP1.Text + "." + tbIP2.Text + "." + ipDiffusion(Convert.ToInt16(tbIP3.Text), cidr) + ".254";
                    lbHote.Text = "Nombre d'hotes : " + Convert.ToString(Math.Pow(2, (32 - cidr)) - 2);
                }
                else
                {
                    if (cidr > 8)
                    {
                        lbMasque.Text = "Masque : 255." + masqueReseau(cidr) + ".0.0";
                        lbReseau.Text = "Adresse Reseau : " + tbIP1.Text + "." + ipReseau(Convert.ToInt16(tbIP2.Text), cidr) + ".0.0";
                        lbDiffusion.Text = "Adresse de diffusion : " + tbIP1.Text + "." + ipDiffusion(Convert.ToInt16(tbIP2.Text), cidr) + ".255.255";
                        lbPlage.Text = "Plage d'adresse : " + tbIP1.Text + "." + ipReseau(Convert.ToInt16(tbIP2.Text), cidr) + ".0.1" + " --> " + //continue sur la ligne suivante
                        tbIP1.Text + "." + ipDiffusion(Convert.ToInt16(tbIP2.Text), cidr) + ".255.254";
                        lbHote.Text = "Nombre d'hotes : " + Convert.ToString(Math.Pow(2, (32 - cidr)) - 2);
                    }
                    else
                    {
                        lbMasque.Text = "Masque : " + masqueReseau(cidr) + ".0.0.0";
                        lbReseau.Text = "Adresse Reseau : " + ipReseau(Convert.ToInt16(tbIP1.Text), cidr) + ".0.0.0";
                        lbDiffusion.Text = "Adresse de diffusion : " + ipDiffusion(Convert.ToInt16(tbIP1.Text), cidr) + ".255.255.255";
                        lbPlage.Text = "Plage d'adresse : " + ipReseau(Convert.ToInt16(tbIP1.Text), cidr) + ".0.0.1" + " --> " + ipDiffusion(Convert.ToInt16(tbIP1.Text), cidr) + ".255.255.254";
                        lbHote.Text = "Nombre d'hotes : " + Convert.ToString(Math.Pow(2, (32 - cidr)) - 2);
                    }

                }
            }
        }
        //Cette Fonction permet de récupéré la partie réseau de l'ip saisie
        public string ipReseau(int ip, int cidr)
        {
            //On convertie l'ip saisie en base 2
            string ipBinaire = Convert.ToString(ip, 2);
            //Comme on travail sur un octet il faut vérifié que l'ip en base 2 est bien contenu sur une chaine de taille 8
            //la conversion en base 2 ne complete pas avec des 0 / exemple 54 = 110110
            if (ipBinaire.Length != 8)
            {
                string complement = "";
                for (int j = 0; j < 8 - ipBinaire.Length; j++)
                {
                    complement = complement + "0";
                }
                ipBinaire = complement + ipBinaire;
            }
            //apres cette condition 54 seras égal a 00110110


            string reste = "";
            //cette boucle permet de compléter l'ip réseau avec des 0 de sorte a ce que la chaine est une taille de 8 caractères
            for (int j = 0; j < 8 - (cidr%8); j++)
            {
                reste = reste + "0";
            }
            //on utilise la méthode substring pour ne prendre que les bits réseau et la boucle précédente pour compléter avec des 0
            //exemple 192.168.1.10 / 12 on utilise 4 bit pour lé réseau donc 1010 | puis on complte avec des 0
            string ipReseau = ipBinaire.Substring(0, cidr%8) + reste;//suivant l'exemple ipRéseau 1010|0000
            ipReseau = Convert.ToInt16(ipReseau, 2).ToString();//on reconvertit l'ip base 2 en base 10

            return ipReseau;//on retourne cette ip
        }


        public string ipDiffusion(int ip, int cidr)//la fonction diffusion est similaire a réseau on compléte juste avec des 1 au lieu de 0
        {
            string ipBinaire = Convert.ToString(ip, 2);
            if (ipBinaire.Length != 8)
            {
                string complement = "";
                for (int j = 0; j < 8 - ipBinaire.Length; j++)
                {
                    complement = complement + "0";
                }
                ipBinaire = complement + ipBinaire;
            }
            string reste = "";
            for (int j = 0; j <8 - (cidr%8); j++)
            {
                reste = reste + "1";
            }
            //on complete avec des 1
            string ipReseau = ipBinaire.Substring(0, cidr%8) + reste;
            ipReseau = Convert.ToInt16(ipReseau, 2).ToString();

            return ipReseau;
        }

        //la fonction masque permet d'obtenir l'adresse du masque réseau
        public string masqueReseau(int cidr)
        {
            string ip = "";
            //on convertit le CIDR compris entre 1 et 8 en uen chaine de caractère "1"
            for (int i = 0; i < cidr%8; i++)
            {
                ip = ip + "1";
            }

            string reste = "";
            //comme pour les méthodes diffusion et réseau on compléte avec des "0" pour obtenir un octet
            for (int i = 0; i < 8 - (cidr%8); i++)
            {
                reste = reste + "0";
            }
            //exemple un CIDR de 28 seras ramené a 4 ( comme > 24 | 28-24 =4)
            //il y aura donc un octet de la forme 11110000

            //on convertit l'octet en base 10 et on retourne sa valeur
            return Convert.ToInt16(ip + reste, 2).ToString();
        }

        public bool verifSaisie(string s)
        {
            int i;
            //la méthode TryParse permet de tester le type de variable saisie dans la textbox si c'est un entier cela retourne la valeur True
            bool saisie = Int32.TryParse(s, out i);
            return saisie;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbIP2.Text == "" || tbIP1.Text == "" || tbIP3.Text == "" || tbIP3.Text == "" || tbCIDR.Text == "")
            {
                
                lbErreur.Text = "Erreur : Il est nécessaire que tout les champs soient remplis";
            }
            else
            {
                if (verifSaisie(tbCIDR.Text) == false)
                {
                    lbErreur.Text = "Erreur : Le CIDR doit etre un chiffre";
                }
                else
                {
                    if (verifSaisie(tbIP2.Text) == false || verifSaisie(tbIP1.Text) == false || verifSaisie(tbIP3.Text) == false || verifSaisie(tbIP4.Text) == false)
                    {
                        lbErreur.Text = "Erreur : L'ip doit etre un chiffre";
                    }
                    else
                    {
                        if ((Convert.ToInt16(tbIP2.Text) > 255 || Convert.ToInt16(tbIP2.Text) < 0) || (Convert.ToInt16(tbIP1.Text) > 255 || Convert.ToInt16(tbIP1.Text) < 0) || (Convert.ToInt16(tbIP3.Text) > 255 || Convert.ToInt16(tbIP3.Text) < 0) || (Convert.ToInt16(tbIP4.Text) > 255 || Convert.ToInt16(tbIP4.Text) < 0))
                        {
                            lbErreur.Text = "Erreur : Une IP est codé de 1 à 255";
                        }
                        else
                        {
                            if (Convert.ToInt16(tbCIDR.Text) > 31 || Convert.ToInt16(tbCIDR.Text) < 1)
                            {
                                lbErreur.Text = "Erreur :  Le CIDR est compris de 1 a 31";
                            }
                            else
                            {
                                int cidr = Convert.ToInt16(tbCIDR.Text);
                                afficheParam(ref cidr);
                                lbErreur.Text = "";

                            }
                        }

                    }

                }
            }

        }
    }

}

