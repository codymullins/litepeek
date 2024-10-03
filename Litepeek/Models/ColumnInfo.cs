namespace Litepeek.Models;

public record ColumnInfo
{
    public required string Name { get; set; }
    public required string Type { get; set; }
}