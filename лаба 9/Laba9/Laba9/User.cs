using System;

namespace Laba9
{
    public static class User
    {
        public delegate void Action();
        public static event Action<string> OnUpgrade; //определение события
        public static event Action OnStartWork;
        

        public static void StartWorkWithSoftware(Software software)
        {
            OnStartWork += software.StartWork;
            

            OnStartWork?.Invoke();//вызов события
        }
        
       

        public static void Upgrade(Software software, string newVersion)
        {
            OnUpgrade += software.ChangeVersion; //обновление версии

            OnUpgrade?.Invoke(newVersion);//вызов события

            
        }
    }
}