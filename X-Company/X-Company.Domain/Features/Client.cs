
namespace X_Company.Domain.Features
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Client() { }

        public Client(string name, string address, string phone, string email)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

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

        public override string ToString()
        {
            return $"{this.Name} ({this.Email})"; 
        }
    }
}

