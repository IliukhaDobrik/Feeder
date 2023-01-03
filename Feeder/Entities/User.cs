using Entities.Feeders;

namespace Entities
{
    public sealed class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Feeder> Feeders { get; set; }
    }
}