﻿using Newtonsoft.Json;

namespace EJournalWPF.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class Student
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("firstname")]
        // Имя
        public string FirtsName { get; set; }

        [JsonProperty("lastname")]
        // Фамилия
        public string LastName { get; set; }

        [JsonProperty("middlename")]
        // Отчество
        public string MiddleName { get; set; }

        [JsonProperty("group", Required = Required.DisallowNull)]
        public virtual Group Group { get; set; }

        public Student(long id, string firtsName, string lastName, string middleName)
        {
            this.Id = id;
            this.FirtsName = firtsName.Replace(" ", "");
            this.LastName = lastName.Replace(" ", "");
            this.MiddleName = middleName.Replace(" ", "");
        }
    }
}
