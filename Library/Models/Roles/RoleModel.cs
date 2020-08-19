using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;

namespace Library.Models.Roles
{
    public class RoleModel : IdentityRole<Guid>
    {
        public string Description { get; set; }
        [JsonIgnore]
        public override string NormalizedName { get => base.NormalizedName; set => base.NormalizedName = value; }
        [JsonIgnore]
        public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }

        public RoleModel() { }

        public RoleModel(string name, string description = "") : base(name) => Description = description;
    }
}
