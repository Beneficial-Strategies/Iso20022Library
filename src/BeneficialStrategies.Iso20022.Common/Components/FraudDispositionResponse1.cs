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
[IsoId("_M5RKcXdoEeeKH6vrEwvLHA")]
[DisplayName("Fraud Disposition Response")]
public record FraudDispositionResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NEuMgXdoEeeKH6vrEwvLHA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment10 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_YI7MQWdwEemXfKijhrqa-Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// contains transaction details of fraud disposition response.
    /// </summary>
    [IsoId("_naNeIZjIEeeMBq7G6mQ32Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction93 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing of the fraud reporting.
    /// </summary>
    [IsoId("_NEuMg3doEeeKH6vrEwvLHA")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_WC83YZjIEeeMBq7G6mQ32Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
