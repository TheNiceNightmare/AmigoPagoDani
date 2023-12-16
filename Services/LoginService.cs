using AmigoPagoDani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoPagoDani.Services
{
    public class LoginService : ILoginService
    {
        public async Task<bool> LoginAsync(string usuario, string contraseña)
        {
            var result = false; ;
            if (string.IsNullOrEmpty(usuario)) 
            {
                return result;
            }
            if (string.IsNullOrEmpty(contraseña))
            {
                return result;
            }
            await Task.Delay(250);
            var emailList = new KeyValuePair<int, string>();

            string[] emailArray = Settings.EmailList.Split(',');
            var passwordList = new List <KeyValuePair<int, string>>();
            for (int i = 0; i < emailArray.Length; i++) 
            {
                emailList.Add(new(i, emailArray[i]));
            }
             string[] passwordArray = Settings.PasswordList.Split(',');
            var passwordList = new List <KeyValuePair<int, string>>();
            for (int i = 0; i < emailArray.Length; i++) 
            {
                emailList.Add(new(i, emailArray[i]));
            }
    



        }
    }
}
