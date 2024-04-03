namespace TaskForge.Models;

public class ServiceModel {
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? EstimatedTime { get; set; }
    public IEnumerable<IFormFile> Images { get; set; } = [];
}