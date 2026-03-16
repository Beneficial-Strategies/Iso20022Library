// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  fraud disposition response message.
/// </summary>
[IsoId("_1WSMwYgrEeu8-LhY4KPfWg")]
[DisplayName("Fraud Disposition Response")]
public record FraudDispositionResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_1bW6AYgrEeu8-LhY4KPfWg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment28 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_1bW6A4grEeu8-LhY4KPfWg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// contains transaction details of fraud disposition response.
    /// </summary>
    [IsoId("_1bW6BYgrEeu8-LhY4KPfWg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction129 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing of the fraud reporting.
    /// </summary>
    [IsoId("_1bW6B4grEeu8-LhY4KPfWg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult19 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_1bW6CYgrEeu8-LhY4KPfWg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
