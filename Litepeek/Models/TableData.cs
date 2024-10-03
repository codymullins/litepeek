namespace Litepeek.Models;

public record TableData
{
    public required string TableName { get; set; }
    public List<string> Columns { get; set; } = [];
    public List<List<object>> Rows { get; set; } = [];
}