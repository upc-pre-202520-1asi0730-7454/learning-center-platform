using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
///     Represents a category in the ACME Learning Center Platform.
/// </summary>
public class Category
{
    /// <summary>
    ///     Default constructor for the category entity
    /// </summary>
    public Category()
    {
        Name = string.Empty;
    }

    /// <summary>
    ///     Constructor for the category entity
    /// </summary>
    /// <param name="name">
    ///     The name of the category
    /// </param>
    public Category(string name)
    {
        Name = name;
    }

    /// <summary>
    ///     Constructor for the category entity from a create command
    /// </summary>
    /// <param name="command">
    ///     The create category command
    /// </param>
    public Category(CreateCategoryCommand command)
    {
        Name = command.Name;
    }

    /// <summary>
    ///     Gets or sets the unique identifier of the category
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Gets or sets the name of the category
    /// </summary>
    public string Name { get; set; }
}