using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolKitIssue
{
    public class MyPopupPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<BackupData> backupDataList;

        public event PropertyChangedEventHandler PropertyChanged;

        public MyPopupPageViewModel() 
        {
            ObservableCollection<BackupData> tempBackupDataList = new ObservableCollection<BackupData>();

            for (int i = 0; i < 20; i++)
            {
                tempBackupDataList.Add(new BackupData { Name = RandomString() });
            }

            this.BackupDataList = tempBackupDataList;
        }

        public static string RandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public ObservableCollection<BackupData> BackupDataList
        {
            get
            {
                if (this.backupDataList == null)
                {
                    this.backupDataList = new ObservableCollection<BackupData>();
                }

                return backupDataList;
            }
            set
            {
                backupDataList = value;
                OnPropertyChanged("BackupDataList");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class BackupData
    {
        public string Name { get; set; }
    }
}
