
namespace X_Company.Domain.Features
{
    public class Client(string name, string address, string phone, string email) : BaseEntity
    {
        public string Name { get; set; } = name;
        public string Address { get; set; } = address;
        public string Phone { get; set; } = phone;
        public string Email { get; set; } = email;

        public override string Validate()
        {
            var result = "";
            if (string.IsNullOrWhiteSpace(Name))
            {
                result += "* Attribute Name cannot be null or white space.\n";
            }
            if (string.IsNullOrWhiteSpace(Address))
            {
                result += "* Attribute Address cannot be null or white space.\n";
            }
            if (string.IsNullOrEmpty(Phone))        //todo: real phone validation
            {
                result += "* Attribute Phone cannot be null or white space.\n";
            }
            if (string.IsNullOrEmpty(Email))        //todo: real email validation
            {
                result += "* Attribute Email cannot be null or white space.\n";
            }
            if (result == "")
                result = "VALID";
            return result;
        }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   id == client.id &&
                   Id == client.Id &&
                   Name == client.Name &&
                   Address == client.Address &&
                   Phone == client.Phone &&
                   Email == client.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, Id, Name, Address, Phone, Email);
        }
    }
}

