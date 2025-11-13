using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregate;

/// <summary>
///     Tutorial aggregate root entity
/// </summary>
/// <remarks>
///     This class is used to represent a tutorial in the application.
/// </remarks>
public partial class Tutorial
{
    /// <summary>
    ///     Default constructor for the tutorial entity
    /// </summary>
    /// <param name="title">
    ///     The title of the tutorial
    /// </param>
    /// <param name="summary">
    ///     The summary of the tutorial
    /// </param>
    /// <param name="categoryId">
    ///     The category id for the tutorial
    /// </param>
    public Tutorial(string title, string summary, int categoryId) : this()
    {
        Title = title;
        Summary = summary;
        CategoryId = categoryId;
    }

    /// <summary>
    ///     Constructor for the tutorial entity from a create command
    /// </summary>
    /// <param name="command">
    ///     The create tutorial command
    /// </param>
    public Tutorial(CreateTutorialCommand command) : this(command.Title, command.Summary, command.CategoryId)
    {
    }

    /// <summary>
    ///     Gets the unique identifier of the tutorial
    /// </summary>
    public int Id { get; }

    /// <summary>
    ///     Gets the title of the tutorial
    /// </summary>
    public string Title { get; private set; }

    /// <summary>
    ///     Gets the summary of the tutorial
    /// </summary>
    public string Summary { get; private set; }

    /// <summary>
    ///     Gets the category of the tutorial
    /// </summary>
    public Category Category { get; internal set; }

    /// <summary>
    ///     Gets the category id of the tutorial
    /// </summary>
    public int CategoryId { get; private set; }
}