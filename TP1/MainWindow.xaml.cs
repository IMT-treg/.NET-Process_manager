using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;


namespace TP1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Liste des applications ouvertes
        private List<Process> processus;

        //Compteur d'applications ballons
        private int numberBaloons;

        //Compteur d'applications Premier
        private int numberPremier;

        private delegate void myDelegate();
        
        //Constructeur
        public MainWindow()
        {
            InitializeComponent();
            this.processus = new List<Process>();
            this.numberBaloons = 0;
            this.numberPremier = 0;
        }

        //méthode qui gère l'ouverture des menus
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        //Méthode qui lance une application Ballon
        private void LaunchBallon(object sender, RoutedEventArgs e)
        {
            Process ballon = new Process();
            ballon.StartInfo = new ProcessStartInfo();
            ballon.StartInfo.FileName = "Ballon.exe";
            ballon.EnableRaisingEvents = true;
            ballon.Exited += new EventHandler(BaloonExit);
            ballon.Start();
            processus.Add(ballon);
            Update();
        }

        //Méthode qui va permettre de prendre en compte la fermeture d'un programme Ballon avec la croix
        private void BaloonExit(object sender, System.EventArgs e)
        {
            this.processus.Remove((Process)sender);
            this.Dispatcher.Invoke(new myDelegate(Update));
        }


        //méthode qui lance une application Premier
        private void LaunchPremier(object sender, RoutedEventArgs e)
        {
            Process premier = new Process();
            premier.StartInfo = new ProcessStartInfo();
            premier.StartInfo.FileName = "Premier.exe";
            premier.EnableRaisingEvents = true;
            premier.Exited += new EventHandler(PremierExit);
            premier.Start();
            this.processus.Add(premier);
            Update();
        }

        //Méthode qui va permettre de prendre en compte la fermeture d'un programme Premier avec la croix
        private void PremierExit(object sender, System.EventArgs e)
        {
            this.processus.Remove((Process)sender);
            this.Dispatcher.Invoke(new myDelegate(Update));
        }

        //Méthode qui update le compteur d'application Ballon ouvertes
        private void UpdateBallonCount()
        {
            List<Process> list = this.processus.FindAll(x => x.ProcessName == "Ballon");
            this.numberBaloons = list.Count();
            this.BaloonCount.Text = this.numberBaloons.ToString();
        }

        //Méthode qui update le compteur d'application Premier ouvertes
        private void UpdatePremierCount()
        {
            List<Process> list = this.processus.FindAll(x => x.ProcessName == "Premier");
            this.numberPremier = list.Count();
            this.PremierCount.Text = this.numberPremier.ToString();
        }

        //Méthode qui update le compteur d'applications ouvertes
        private void UpdateProcessCount() 
        {
            this.ProcessCount.Text = this.processus.Count.ToString();
        }

        //Méthode qui update le tableau des applications ouvertes
        private void UpdateListProcessus()
        {
            string listProcessus = null;
            foreach(Process p in this.processus)
            {
                listProcessus += p.ProcessName + ", ID : " + p.Id + "\n";
            }
            ProcessList.Text = listProcessus;
        }

        //Méthode qui update les valeurs des compteurs
        private void Update()
        {
            UpdateBallonCount();
            UpdatePremierCount();
            UpdateProcessCount();
            UpdateListProcessus();
        }

        //Méthode qui va fermer toutes les applications ouvertes. 
        private void KillAllProcessus(object sender, RoutedEventArgs e)
        {
            if(this.processus.Any() == true)
            {
                List<Process> processBis = new List<Process>(this.processus);
                foreach (Process p in processBis)
                {
                    p.Kill();
                    this.processus.Remove(p);
                }
                Update();
            }
        }

        //Méthode qui va fermer la dernière application qui a été ouverte.
        private void KillLastProcessus(object sender, RoutedEventArgs e)
        {
            if (this.processus.Any() == true)
            {
                Process lastProcess = this.processus.Last();
                lastProcess.Kill();
                this.processus.Remove(lastProcess);
                Update();
            }
            
        }

        //Méthode qui va fermer la dernière application Ballon ouverte
        private void KillLastBaloon(object sender, RoutedEventArgs e)
        {
            if(this.processus.FindAll(x => x.ProcessName=="Ballon").Any()==true)
            {
                Process lastBaloon = this.processus.FindLast(x => x.ProcessName == "Ballon");
                lastBaloon.Kill();
                this.processus.Remove(lastBaloon);
                Update();
            }
            
        }

        //Méthode qui va fermer la dernière application Premier qui a été ouverte
        private void KillLastPremier(object sender, RoutedEventArgs e)
        {
            if (this.processus.FindAll(x => x.ProcessName == "Premier").Any() == true)
            {
                Process lastPremier = this.processus.FindLast(x => x.ProcessName == "Premier");
                lastPremier.Kill();
                this.processus.Remove(lastPremier);
                Update();
            }
                
        }

        //Méthode qui va fermer toutes les applications Ballon ouvertes
        private void KillAllBaloons(object sender, RoutedEventArgs e)
        {
            List<Process> allBaloons = new List<Process>();
            allBaloons = this.processus.FindAll(x => x.ProcessName == "Ballon");
            if(allBaloons.Any()==true)
            {
                foreach (Process p in allBaloons)
                {
                    p.Kill();
                    this.processus.Remove(p);
                }
                Update();
            }
        }

        //Méthode qui va fermer toutes les applications Premier ouvertes
        private void KillAllPremiers(object sender, RoutedEventArgs e)
        {
            List<Process> allPremiers = new List<Process>();
            allPremiers = this.processus.FindAll(x => x.ProcessName == "Premier");
            if(allPremiers.Any()==true)
            {
                foreach (Process p in allPremiers)
                {
                    p.Kill();
                    this.processus.Remove(p);
                }
                Update();
            }
        }


        //Méthode qui va fermer toutes les applications en cours ainsi que la fenetre principale lorqu'on clique sur le menu "quit"
        private void Quit(object sender, RoutedEventArgs e)
        {
            KillAllProcessus(sender, e);
            this.Close();
        }

        //Méthode permettant de fermer tous les ballons et les premiers en cours
        private void KillAll()
        {
            
            foreach(Process p in this.processus)
            {
                p.Kill();
            }

        }

        //Méthode qui va fermer toutes les ballons et les premiers ouverts lorsqu'on clique sur la croix de l'application principale
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.processus.Any() == true)
            {
                KillAll();
            }
        }
    }
}
