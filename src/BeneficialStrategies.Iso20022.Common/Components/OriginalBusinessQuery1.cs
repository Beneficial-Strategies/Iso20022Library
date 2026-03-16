// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business query message.
/// </summary>
[IsoId("_tsOu4FkyEeGeoaLUQk__nA_1838839671")]
[DisplayName("Original Business Query")]
public record OriginalBusinessQuery1
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original query message.
    /// </summary>
    [IsoId("_tsOu4VkyEeGeoaLUQk__nA_1725000605")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    [IsoId("_tsOu4lkyEeGeoaLUQk__nA_727928252")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_tsOu41kyEeGeoaLUQk__nA_-269144101")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
