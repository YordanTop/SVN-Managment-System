
namespace DataBaseLayer.Models
{
    public partial class User
    {
        /// <summary>
        /// EN: Type of permits
        /// <para>BG: Различни правомощия</para>
        /// </summary>
        public enum UserAccessRole
        {
            /// <summary>
            /// EN: Has restricted access
            /// </summary>
            User = 0,
            /// <summary>
            /// EN: Has full access
            /// </summary>
            Admin = 1,
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public UserAccessRole Role { get; set; }
        public string Password { get; set; }
    }
}
