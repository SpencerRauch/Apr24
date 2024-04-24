using FirstBlazor.Entity;

namespace FirstBlazor.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
    Task<Game> AddGame(Game game);
}