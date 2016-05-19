using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be compressed and decompressed
/// </summary>
public class CompressableBehavior : BaseBehavior
{
    /// <summary>
    /// The factor to compress or expand an object by
    /// </summary>
    private readonly int objectCompressRatio = 2;

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="baseGameObject">Object to operate on</param>
    public CompressableBehavior(GameObject baseGameObject)
        : base(baseGameObject)
    {
        Behavior = BeaverBehaviorsEnum.Compress;
    }

    /// <summary>
    ///     Whether or not the object is compressed or still compressable
    /// </summary>
    private bool IsCompressed { get; set; }

    /// <summary>
    ///     Compresses the object if !IsCompressed. Else undoes it
    /// </summary>
    protected override void Execute()
    {
        if (IsCompressed)
        {
            BaseGameObject.transform.localScale *= objectCompressRatio;
        }
        else
        {
            BaseGameObject.transform.localScale /= objectCompressRatio;
        }

        IsCompressed = !IsCompressed;
    }
}