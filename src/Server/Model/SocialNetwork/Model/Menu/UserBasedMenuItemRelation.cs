namespace odec.Server.Model.SocialNetwork.Model.Menu
{
    public class UserBasedMenuItemRelation:Server.Model.Menu.MenuItemRelation
    {
        public int UserId { get; set; }

        public User.User User { get; set; }
    }
}
