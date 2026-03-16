// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  fraud reporting response message.
/// </summary>
[IsoId("_sJuzIXdcEeeKH6vrEwvLHA")]
[DisplayName("Fraud Reporting Response")]
public record FraudReportingResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_sU46QXdcEeeKH6vrEwvLHA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment10 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_THwYcGdwEemXfKijhrqa-Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Transaction details of fraud reporting response.
    /// </summary>
    [IsoId("_LalXEZizEeefZKJHxQTztg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction93 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing of the fraud reporting.
    /// </summary>
    [IsoId("_lDQDMHddEeeKH6vrEwvLHA")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_RnWQwZiyEeefZKJHxQTztg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
