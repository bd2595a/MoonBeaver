using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be compressed and decompressed 
/// </summary>
public class CompressableBehavior : BaseBehavior
{
    public CompressableBehavior()
    {
        Type = BeaverBehaviorType.Compress;
    }

    /// <summary>
    /// The factor to compress or expand an object by 
    /// </summary>
    private readonly int objectCompressRatio = 2;

    /// <summary>
    /// Whether or not the object is compressed or still compressable 
    /// </summary>
    private bool IsCompressed { get; set; }

    /// <summary>
    /// Compresses the object if !IsCompressed. Else undoes it 
    /// </summary>
    public override void Execute()
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