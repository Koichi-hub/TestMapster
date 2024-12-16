using Mapster;
using Newtonsoft.Json;
using TestMapster.DTO;
using TestMapster.Models;

TypeAdapterConfig<User, UserDTO>
    .NewConfig()
    .Map(dest => dest.Village, src => "Konoha");

var user = new User
{
    Uid = Guid.NewGuid(),
    Name = "Naruto",
};

var userDto = user.Adapt<UserDTO>();

Console.WriteLine(JsonConvert.SerializeObject(userDto));
