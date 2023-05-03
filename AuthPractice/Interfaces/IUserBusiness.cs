using AuthPractice.Enum;
using AuthPractice.Models.DTO;

namespace AuthPractice.Interfaces
{
    public interface IUserBusiness
    {
        public Status Register(UserDto userDto);
        public Tuple<Status, RefreshTokenModel> Login(UserDto userDto);

        public Tuple<Status, RefreshTokenModel> Refresh(RefreshTokenModel refreshTokenModel);
    }
}
