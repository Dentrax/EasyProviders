using System;

namespace EasyProviders.Services.Social {
    public sealed class SocialUser {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool IsUnderage { get; set; }
        public DateTime RefreshedTime { get; set; }


        public string FirstName {
            get {
                if (string.IsNullOrEmpty(this.Name)) return "NULL";
                int num = this.Name.IndexOf(' ');
                if (num != -1) {
                    return this.Name.Substring(0, num);
                }
                return this.Name;
            }
        }

    }
}

