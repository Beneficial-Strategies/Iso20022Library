// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Initiation of a batch transfer exchange.
/// </summary>
[IsoId("_ZUjRwZMrEeuleeHpFMMhmQ")]
[DisplayName("Batch Transfer Initiation")]
public record BatchTransferInitiation2
{
    /// <summary>
    /// Environment of the message.
    /// </summary>
    [IsoId("_ZbjRoZMrEeuleeHpFMMhmQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment4 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_ZbjRo5MrEeuleeHpFMMhmQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Batch transfer transaction.
    /// </summary>
    [IsoId("_ZbjRpZMrEeuleeHpFMMhmQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction141 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing.
    /// </summary>
    [IsoId("_ZbjRp5MrEeuleeHpFMMhmQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult20? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_ZbjRqZMrEeuleeHpFMMhmQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_ZbjRq5MrEeuleeHpFMMhmQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
