using System;
using odec.Server.Model.User.Generic.UnifiedKey;

namespace odec.Server.Model.SocialNetwork.Model.UserModels
{
    /// <summary>
    /// Серверный объект - связь пользователя и контакта
    /// </summary>
    public class UserContact :UserContactGeneric<Int32,Contact.Contact>
    {
    }
}
