namespace GameStore.Api.Dtos;
using System.ComponentModel.DataAnnotations;

public record class UpdateGameDto(
    [Required][StringLength(50)] string name,
    [Required][StringLength(20)] string genre,
    [Range(1, 100)] decimal price,
    DateOnly releaseDate
    );
