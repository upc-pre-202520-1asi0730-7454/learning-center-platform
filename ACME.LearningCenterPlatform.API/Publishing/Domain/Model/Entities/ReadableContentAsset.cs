using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
///     Represents a readable content asset in the ACME Learning Center Platform.
/// </summary>
public class ReadableContentAsset : Asset
{
    /// <summary>
    ///     Default constructor for the readable content asset.
    /// </summary>
    public ReadableContentAsset() : base(EAssetType.ReadableContentItem)
    {
        ReadableContent = string.Empty;
    }

    /// <summary>
    ///     Constructor for the readable content asset with the specified content.
    /// </summary>
    /// <param name="content">The readable content.</param>
    public ReadableContentAsset(string content) : base(EAssetType.ReadableContentItem)
    {
        ReadableContent = content;
    }

    /// <summary>
    ///     Gets or sets the readable content.
    /// </summary>
    public string ReadableContent { get; set; }
    
    /// <summary>
    ///     Gets a value indicating whether the readable content asset is readable.
    /// </summary>
    public override bool Readable => true;
    
    /// <summary>
    ///     Gets a value indicating whether the readable content asset is viewable.
    /// </summary>
    public override bool Viewable => false;
}