namespace BeneficialStrategies.Iso20022.Framework;

/// <summary>
/// Should be implemented by the document wrapper that is placed around each message that establishes the XML namespace.
/// </summary>
/// <typeparam name="TOuterRecord">Data type of the record included inside.</typeparam>
public interface IOuterDocument<TOuterRecord>
    where TOuterRecord : IOuterRecord
{
    /// <summary>
    /// Contains the inner message that contains most of the message content.
    /// </summary>
    public TOuterRecord Message { get; }
}
