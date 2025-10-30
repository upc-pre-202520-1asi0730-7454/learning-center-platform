using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
///     Represents an image asset in the ACME Learning Center Platform.
/// </summary>
public class ImageAsset : Asset
{
    public ImageAsset() : base(EAssetType.Image)
    {
    }

    public ImageAsset(string imageUrl) : base(EAssetType.Image)
    {
        ImageUri = new Uri(imageUrl);
    }

    public Uri? ImageUri { get; }

    public override bool Readable => false;

    public override bool Viewable => true;

    public override string GetContent()
    {
        return ImageUri != null ? ImageUri.AbsoluteUri : string.Empty;
    }
}