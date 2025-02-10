
using GameStore.Api.Dtos;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{

    const string GET_GAME_ENDPOINT_NAME = "GetGame";

    private static readonly List<GameDto> games = [
        new(
        1,
        "GTA V",
        "RPG",
        19.99M,
        new DateOnly(2013, 9, 17)),
    new(
        2,
        "The Witcher 3",
        "RPG",
        29.99M,
        new DateOnly(2015, 5, 19)),
    new(
        3,
        "Cyberpunk 2077",
        "RPG",
        59.99M,
        new DateOnly(2020, 12, 10)),
    new(
        4,
        "FIFA 21",
        "Sports",
        49.99M,
        new DateOnly(2020, 10, 9)),
    new(
        5,
        "NBA 2K21",
        "Sports",
        59.99M,
        new DateOnly(2020, 9, 4)),
    new(
        6,
        "Madden NFL 21",
        "Sports",
        59.99M,
        new DateOnly(2020, 8, 28)),
    new(
        7,
        "F1 2020",
        "Racing",
        59.99M,
        new DateOnly(2020, 7, 10)),
    new(
        8,
        "Forza Horizon 4",
        "Racing",
        29.99M,
        new DateOnly(2018, 10, 2)),
    new(
        9,
        "Gran Turismo Sport",
        "Racing",
        19.99M,
        new DateOnly(2017, 10, 17)),
    new(
        10,
        "Rocket League",
        "Sports",
        19.99M,
        new DateOnly(2015, 7, 7)),
    new(
        11,
        "Red Dead Redemption 2",
        "RPG",
        39.99M,
        new DateOnly(2018, 10, 26)),
    new(
        12,
        "Assassin's Creed Valhalla",
        "RPG",
        59.99M,
        new DateOnly(2020, 11, 10)),
    new(
        13,
        "Call of Duty: Black Ops Cold War",
        "Shooter",
        59.99M,
        new DateOnly(2020, 11, 13)),
    new(
        14,
        "Battlefield V",
        "Shooter",
        19.99M,
        new DateOnly(2018, 11, 20)),
    new(
        15,
        "God of War",
        "Action",
        19.99M,
        new DateOnly(2018, 4, 20))
    ];

    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {

        RouteGroupBuilder group = app.MapGroup("games");

        // GET /games
        group.MapGet("/", () => games);

        // GET /games/1
        group.MapGet("/{id}", (int id) =>
        {
            GameDto? game = games.Find(game => game.id == id);

            return game is null ? Results.NotFound() : Results.Ok(game);
        })
        .WithName(GET_GAME_ENDPOINT_NAME);

        // POST /games
        group.MapPost("/", (CreateGameDto newGame) =>
        {
            GameDto game = new(
                games.Count + 1,
                newGame.name,
                newGame.genre,
                newGame.price,
                newGame.releaseDate
            );
            games.Add(game);

            return Results.CreatedAtRoute(GET_GAME_ENDPOINT_NAME, new { id = game.id }, game);
        })
        .WithParameterValidation();

        // PUT /games/1
        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) =>
        {
            var gameIndex = games.FindIndex(game => game.id == id);
            if (gameIndex == -1)
            {
                return Results.NotFound();
            }
            games[gameIndex] = new GameDto(
                id,
                updatedGame.name,
                updatedGame.genre,
                updatedGame.price,
                updatedGame.releaseDate
            );
            return Results.NoContent();
        });

        // DELETE /games/1
        group.MapDelete("/{id}", (int id) =>
        {
            games.RemoveAll(game => game.id == id);

            return Results.NoContent();
        });

        return group;
    }
}
