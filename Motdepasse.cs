using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AP2
{
    internal class Motdepasse
    {
        private string passwordNoHach;
        private string passwordHach;
        private string sel = null;
        public Motdepasse(string password)
        {
            this.passwordNoHach = password;
            this.sel = genererSel();
            this.passwordHach = hashSHA(password + sel);


        }
        public Motdepasse(string password, string sel)
        {

            this.passwordNoHach = password;
            this.sel = sel;
            this.passwordHach = hashSHA(password + sel);

        }
        public string getMdpHash
        {
            get { return this.passwordHach; }
        }

        public string getSel
        {
            get { return this.sel; }
        }

        public string hashSHA(string mdp)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                return Convert.ToBase64String(hashBytes);
            }
        }
        public string genererSel()
        {
            byte[] sel = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(sel);
            }
            return Convert.ToBase64String(sel);
        }

        public bool verifierMDP(string mdp, string hashStocke, string sel)
        {
            bool result = false;
            string hashAComparer = hashSHA(mdp + sel);
            if(hashAComparer.Length != hashStocke.Length)
            {
                result = false;
            }
            else
            {
                if(hashStocke == hashAComparer)
                {
                    result = true;
                }
            }
            return  result ;

        }

    }
}
