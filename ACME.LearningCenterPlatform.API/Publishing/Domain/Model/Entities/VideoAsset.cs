using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
///     Represents a video asset in the ACME Learning Center Platform.
/// </summary>
public class VideoAsset : Asset
{
    /// <summary>
    ///     Default constructor for the video asset.
    /// </summary>
    public VideoAsset() : base(EAssetType.Video)
    {
        VideoUri = null;
    }

    /// <summary>
    ///     Constructor for the video asset with the specified video URL.
    /// </summary>
    /// <param name="videoUrl">The URL of the video.</param>
    public VideoAsset(string videoUrl) : base(EAssetType.Video)
    {
        VideoUri = new Uri(videoUrl);
    }

    /// <summary>
    ///     Gets the URI of the video.
    /// </summary>
    public Uri? VideoUri { get; private set; }
    
    /// <summary>
    ///     Gets a value indicating whether the video asset is readable.
    /// </summary>
    public override bool Readable => false;
    
    /// <summary>
    ///     Gets a value indicating whether the video asset is viewable.
    /// </summary>
    public override bool Viewable => true;
}