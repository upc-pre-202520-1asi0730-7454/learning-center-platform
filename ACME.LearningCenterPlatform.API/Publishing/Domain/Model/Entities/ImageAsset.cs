using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
///     Represents an image asset in the ACME Learning Center Platform.
/// </summary>
public class ImageAsset : Asset
{
    /// <summary>
    ///     Default constructor for the image asset.
    /// </summary>
    public ImageAsset() : base(EAssetType.Image)
    {
    }

    /// <summary>
    ///     Constructor for the image asset with the specified image URL.
    /// </summary>
    /// <param name="imageUrl">The URL of the image.</param>
    public ImageAsset(string imageUrl) : base(EAssetType.Image)
    {
        ImageUri = new Uri(imageUrl);
    }

    /// <summary>
    ///     Gets the URI of the image.
    /// </summary>
    public Uri? ImageUri { get; }

    /// <summary>
    ///     Gets a value indicating whether the image asset is readable.
    /// </summary>
    public override bool Readable => false;

    /// <summary>
    ///     Gets a value indicating whether the image asset is viewable.
    /// </summary>
    public override bool Viewable => true;

    /// <summary>
    ///     Gets the content of the image asset.
    /// </summary>
    /// <returns>The absolute URI of the image.</returns>
    public override string GetContent()
    {
        return ImageUri != null ? ImageUri.AbsoluteUri : string.Empty;
    }
}