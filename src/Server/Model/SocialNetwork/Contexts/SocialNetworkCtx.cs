using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using odec.CP.Server.Model.Contact.Abst.Interfaces;
using odec.CP.Server.Model.Location;
using odec.CP.Server.Model.Location.Abst.Interfaces;
using odec.CP.Server.Model.User;
using odec.CP.Server.Model.User.Membership;
using odec.CP.Server.Model.User.Membership.FullyCustomized.Models;
using odec.Server.Model.Achievement;
using odec.Server.Model.Achievement.Abst.Interfaces;
using odec.Server.Model.Attachment;
using odec.Server.Model.Attachment.Abst.Interfaces;
using odec.Server.Model.Contact;
using odec.Server.Model.Conversation;
using odec.Server.Model.Conversation.Abstractions;
using odec.Server.Model.Education;
using odec.Server.Model.Education.Abstractions.Interfaces;
using odec.Server.Model.HtmlElements;
using odec.Server.Model.Language;
using odec.Server.Model.Language.Abstractions.Interfaces;
using odec.Server.Model.Language.Abstractions.Interfaces.Links;
using odec.Server.Model.Location;
using odec.Server.Model.Menu;
using odec.Server.Model.Menu.Abstractions.Interfaces;
using odec.Server.Model.Menu.Abstractions.Interfaces.Links;
using odec.Server.Model.Message;
using odec.Server.Model.Message.Abst.Interfaces;
using odec.Server.Model.Message.Abst.Interfaces.Links;
using odec.Server.Model.SocialNetwork.Model;
using odec.Server.Model.SocialNetwork.Model.Extended;
using odec.Server.Model.SocialNetwork.Model.Menu;
using odec.Server.Model.SocialNetwork.Model.UserModels;
using odec.Server.Model.User;
using odec.Server.Model.User.Abst.Interfaces;
using odec.Server.Model.User.Abst.Interfaces.Links;
using odec.Server.Model.User.Abst.Interfaces.Refactor;
using odec.Server.Model.User.Refactor;
using odec.Server.Model.Wall;
using odec.Server.Model.Wall.Abstractions.Interfaces;
using odec.Server.Model.Wall.Abstractions.Interfaces.Links;
using Categ = odec.Server.Model.Category.Category;
using Hobby = odec.Server.Model.User.Hobby;
using UserContact = odec.Server.Model.User.UserContact;
using UserHobby = odec.Server.Model.User.UserHobby;
using UserMovie = odec.Server.Model.User.UserMovie;
using Cont = odec.Server.Model.Contact.Contact;
using UserRelationship = odec.Server.Model.User.UserRelationship;
using Usr = odec.CP.Server.Model.User.Membership.Simple.Models.User;
using Role = odec.CP.Server.Model.User.Membership.Simple.Models.Role;
using Conv = odec.Server.Model.Conversation.Conversation;
using WallE = odec.Server.Model.Wall.Wall;
using AchievementE = odec.Server.Model.Achievement.Achievement;
using Lang = odec.Server.Model.Language.Language;
using Attach = odec.Server.Model.Attachment.Attachment;
using UserRole = odec.Server.Model.User.UserRole;

namespace odec.Server.Model.SocialNetwork.Contexts
{
    /// <summary>
    /// контекст базы данных
    /// </summary>
    public class SocialNetworkCtx :
        IdentityDbContext<Usr, Role, int>,
        IUserContextExt<int, Usr, Role, IdentityUserRole<int>, Cont, Phone, PhoneType, ContactPhone, FeedBackComment, EmailUrlRelation, Sex, Hobby, UserHobby>,
        IRouteMenuItemsContext<MenuItem, UserBasedMenuItemRelation, MenuItemRelationRouteValue, RouteParam, RouteName, MenuItemRelationGroup>,
        IMenuItemRelationHtmlAttributeContext<MenuItemRelationHtmlAttribute>,
        IHtmlAttributesNamesContext<HtmlAttr>,
        IContactAddress<ContactAddress>,
        ILocationContext<Address, Country, City, Subway, Street, House, Housing, Flat>,
        IAchievementContext<AchievementE, UserAchievement, Reward, RewardType, AchievementReward, AchievementConfirmation, Confirmation>,
        IMessagesContext<Message.Message, MessageType, MessageMessageType>,
        IAttachmentContext<Attach, AttachmentType>,
        IConversationContext<Conv, ConversationType, ConversationUser, ConversationMessage>,
        IFriendsContext<Friend, FriendGroup>,
        IMoviesContext<Movie, MovieCategory, Categ>,
        IMessageAttachmentContext<MessageAttachment>,
        IPartnersContext<Partner, PartnerProgram>,
        IWallContext<WallMessage, WallE>,
        IUserWallContext<UserWall>,
        IUserContactContext<UserContact>,
        ILanguagesContext<Lang>,
        IUserLanguagesContext<UserLanguage>,
        IRelationshipContext<Relationship>,
        IUserRelationshipsContext<UserRelationship>,
        IUserEducation<UserEducation>,
        IUserMovieContext<UserMovie>,
        IAlbumsContext<Album, FotoRelation, Image>,
        IUserAlbumContext<UserAlbum>,
        IEducationContext<EducationType, EducationUnit, EndUpEducationDocumentType, Specialization, EducationTypeEducationUnit, EducationUnitSpecialization>
    {

        private string MembershipScheme = "AspNet";
        public static SocialNetworkCtx Create()
        {
            return new SocialNetworkCtx();
        }
        /// <summary>
        /// конструктор по умолчанию. использует строку подключения ToursSocial
        /// </summary>
        public SocialNetworkCtx() : base()
        {
        }

        /// <summary>
        /// таблица хобби
        /// </summary>
        public DbSet<Hobby> Hobbies { get; set; }

        /// <summary>
        /// таблица связи пользователя и хобби
        /// </summary>
        public DbSet<UserHobby> UserHobbies { get; set; }

        /// <summary>
        /// таблица полов
        /// </summary>
        public DbSet<Sex> Sexes { get; set; }

        /// <summary>
        /// таблица телефонов
        /// </summary>
        public DbSet<Phone> Phones { get; set; }

        /// <summary>
        /// таблица типов телефонов
        /// </summary>
        public DbSet<PhoneType> PhoneTypes { get; set; }

        /// <summary>
        /// таблица связи телефонов и контактов
        /// </summary>
        public DbSet<ContactPhone> ContactPhones { get; set; }

        /// <summary>
        /// таблица обратной связи
        /// </summary>
        public DbSet<FeedBackComment> FeedBacks { get; set; }

        /// <summary>
        /// таблица связи эл.почты и ссылок на основные почтовые ресурсы (исп. для восстановления доступа)
        /// </summary>
        public DbSet<EmailUrlRelation> EmailUrlRelations { get; set; }

        /// <summary>
        /// таблица контактов
        /// </summary>
        public DbSet<Cont> Contacts { get; set; }
        /// <summary>
        /// таблица адресов
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// таблица стран
        /// </summary>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// таблица городов
        /// </summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>
        /// таблица метро
        /// </summary>
        public DbSet<Subway> Subways { get; set; }

        /// <summary>
        /// таблица улиц
        /// </summary>
        public DbSet<Street> Streets { get; set; }

        /// <summary>
        /// таблица домов
        /// </summary>
        public DbSet<House> Houses { get; set; }

        /// <summary>
        /// таблица корпусов
        /// </summary>
        public DbSet<Housing> Housings { get; set; }

        /// <summary>
        /// таблица квартир
        /// </summary>
        public DbSet<Flat> Flats { get; set; }

        /// <summary>
        /// таблица связи контакта и адреса
        /// </summary>
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        /// <summary>
        /// таблица достижений
        /// </summary>
        public DbSet<AchievementE> Achievement { get; set; }
        /// <summary>
        /// таблица связи достижения пользователя
        /// </summary>
        public DbSet<AchievementConfirmation> AchievementConfirmations { get; set; }

        /// <summary>
        /// таблица Справочник подтверждений(к примеру подтверждения достижения)
        /// </summary>

        public DbSet<Confirmation> Confirmation { get; set; }
        /// <summary>
        /// таблица связи пользователя и достижения
        /// </summary>
        public DbSet<UserAchievement> UserAchievement { get; set; }
        /// <summary>
        /// таблица награды
        /// </summary>
        public DbSet<Reward> Rewards { get; set; }

        /// <summary>
        /// таблица типов награды
        /// </summary>
        public DbSet<RewardType> RewardTypes { get; set; }
        /// <summary>
        /// таблица связи награды за достижения
        /// </summary>
        public DbSet<AchievementReward> AchievementRewards { get; set; }
        /// <summary>
        /// таблица сообщений
        /// </summary>
        public DbSet<Message.Message> Messages { get; set; }

        /// <summary>
        /// таблица типов сообщений
        /// </summary>
        public DbSet<MessageType> MessageMessageTypes { get; set; }

        /// <summary>
        /// таблица связи сообщения и типа сообщения
        /// </summary>
        public DbSet<MessageMessageType> MessageTypeses { get; set; }

        /// <summary>
        /// таблица вложений
        /// </summary>
        public DbSet<Attach> Attachments { get; set; }

        /// <summary>
        /// таблица типов вложений
        /// </summary>
        public DbSet<AttachmentType> AttachmentTypes { get; set; }

        /// <summary>
        /// таблица конференций (обсуждений)
        /// </summary>
        public DbSet<Conv> Conversations { get; set; }

        /// <summary>
        /// таблица типов конференций (обсуждений)
        /// </summary>
        public DbSet<ConversationType> ConversationTypes { get; set; }

        /// <summary>
        /// таблица связи конференций (обсуждений) и пользователя
        /// </summary>
        public DbSet<ConversationUser> ConversationUsers { get; set; }

        /// <summary>
        /// таблица связи конференций (обсуждений) и сообщения
        /// </summary>
        public DbSet<ConversationMessage> ConversationMessages { get; set; }

        /// <summary>
        /// таблица связи между пользователем и его друзьями
        /// </summary>
        public DbSet<Friend> Friends { get; set; }

        /// <summary>
        /// таблица группы друзей (категории)
        /// </summary>
        public DbSet<FriendGroup> FriendGroups { get; set; }

        /// <summary>
        /// таблица видеозаписей
        /// </summary>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// таблица категорий видеороликов
        /// </summary>
        public DbSet<MovieCategory> MovieCategories { get; set; }

        /// <summary>
        /// таблица категорий
        /// </summary>
        public DbSet<Categ> Categories { get; set; }

        /// <summary>
        /// таблица связи сообщения и вложения
        /// </summary>
        public DbSet<MessageAttachment> MessageAttachments { get; set; }

        /// <summary>
        /// таблица партнеров
        /// </summary>
        public DbSet<Partner> Partners { get; set; }

        /// <summary>
        /// таблица партнерской программы
        /// </summary>
        public DbSet<PartnerProgram> PartnerPrograms { get; set; }


        /// <summary>
        /// таблица стен
        /// </summary>
        public DbSet<WallE> Walls { get; set; }

        /// <summary>
        /// таблица сообщений на стене
        /// </summary>
        public DbSet<WallMessage> WallMessages { get; set; }

        /// <summary>
        /// таблица связи пользователя и стены
        /// </summary>
        public DbSet<UserWall> UserWalls { get; set; }

        /// <summary>
        /// таблица связи пользователя и контакта
        /// </summary>
        public DbSet<UserContact> UserContacts { get; set; }

        /// <summary>
        /// таблица языков
        /// </summary>
        public DbSet<Lang> Languages { get; set; }

        /// <summary>
        /// таблица связи пользователя и языка
        /// </summary>
        public DbSet<UserLanguage> UserLanguages { get; set; }

        /// <summary>
        /// таблица отношений (замужем и проч.)
        /// </summary>
        public DbSet<Relationship> Relationships { get; set; }

        /// <summary>
        /// таблица связей отношения- пользователи
        /// </summary>
        public DbSet<UserRelationship> UserRelationships { get; set; }

        /// <summary>
        /// таблица связи юзера и обучения. Характерезует где, когда, как и почему учился пользователь
        /// </summary>
        public DbSet<UserEducation> UserEducations { get; set; }

        /// <summary>
        /// таблица связи пользователя и фильма
        /// </summary>
        public DbSet<UserMovie> UserMovies { get; set; }

        /// <summary>
        /// таблица альбомов
        /// </summary>
        public DbSet<Album> Albums { get; set; }

        /// <summary>
        /// таблица связей фотографий
        /// </summary>
        public DbSet<FotoRelation> FotoRelations { get; set; }

        /// <summary>
        /// Таблица фото
        /// </summary>
        public DbSet<Image> Fotos { get; set; }

        /// <summary>
        /// таблица связи пользователя и альбома
        /// </summary>
        public DbSet<UserAlbum> UserAlbums { get; set; }
        /// <summary>
        /// метод определяющий по каким правилам должна создаваться модель бд(контекст бд)
        /// </summary>
        /// <param name="modelBuilder">построитель модели</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usr>().ToTable("Users", "AspNet");
            modelBuilder.Entity<Role>().ToTable("Roles", "AspNet");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles", MembershipScheme);
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims", MembershipScheme);
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins", MembershipScheme);
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims", MembershipScheme);
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens", MembershipScheme);
            //  modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// таблица блоков образования
        /// </summary>
        public DbSet<EducationUnit> EducationUnits { get; set; }

        /// <summary>
        /// таблица связи блоков образования и типа образования
        /// </summary>
        public DbSet<EducationTypeEducationUnit> EducationUnitEducationTypes { get; set; }

        /// <summary>
        /// таблица типов документов об образовании
        /// </summary>
        public DbSet<EndUpEducationDocumentType> EndUpDocumentTypes { get; set; }

        /// <summary>
        /// таблица специальности по диплому
        /// </summary>
        public DbSet<EducationUnitSpecialization> EducationUnitSpecializationses { get; set; }

        /// <summary>
        /// таблица специальностей
        /// </summary>
        public DbSet<Specialization> Specializations { get; set; }

        /// <summary>
        /// таблица типов образования
        /// </summary>
        public DbSet<EducationType> EducationTypes { get; set; }


        /// <summary>
        /// таблица связи меню
        /// </summary>
        public DbSet<MenuItem> MenuItems { get; set; }

        /// <summary>
        /// таблица связи отношения меню
        /// </summary>
        public DbSet<UserBasedMenuItemRelation> MenuItemRelations { get; set; }

        public DbSet<MenuItemRelationGroup> MenuItemRelationGroups { get; set; }

        /// <summary>
        /// Route names (default etc)
        /// </summary>
        public DbSet<RouteName> RouteNames { get; set; }

        /// <summary>
        /// Route params (like controller, action)
        /// </summary>
        public DbSet<RouteParam> RouteParams { get; set; }

        /// <summary>
        /// RouteValues for special MenuItemRelation
        /// </summary>
        public DbSet<MenuItemRelationRouteValue> MenuItemRelationRouteValues { get; set; }

        public DbSet<MenuItemRelationHtmlAttribute> MenuItemRelationHtmlAttrs { get; set; }

        /// <summary>
        /// Names of html attributes like id,name etc
        /// </summary>
        public DbSet<HtmlAttr> HtmlAttributeNames { get; set; }
    }

}
