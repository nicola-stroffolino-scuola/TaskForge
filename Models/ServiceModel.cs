using System.ComponentModel.DataAnnotations;

namespace TaskForge.Models;

public class ServiceModel {
    [Required]
    public required string Title { get; set; }
    public string? Description { get; set; }
    [Required]
    public required double Price { get; set; }
    [Required]
    [Display(Name = "Estimated Time")]
    public required string EstimatedTime { get; set; }
    public IEnumerable<IFormFile>? Images { get; set; } = [];
}