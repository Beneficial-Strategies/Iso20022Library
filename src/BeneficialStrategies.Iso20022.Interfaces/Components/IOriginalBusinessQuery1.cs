// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business query message.
/// </summary>
[IsoId("_tsOu4FkyEeGeoaLUQk__nA_1838839671")]
public interface IOriginalBusinessQuery1 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original query message.
    /// </summary>
    [IsoId("_tsOu4VkyEeGeoaLUQk__nA_1725000605")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    [IsoId("_tsOu4lkyEeGeoaLUQk__nA_727928252")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    IsoMax35Text? MessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tsOu41kyEeGeoaLUQk__nA_-269144101")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime? CreationDateTime { get; }
}
