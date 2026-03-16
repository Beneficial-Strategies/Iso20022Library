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
[IsoId("_U-EzMYv4EeumSPwlS1PkxQ")]
[DisplayName("Fraud Reporting Response")]
public record FraudReportingResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_VDLVoYv4EeumSPwlS1PkxQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment28 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_VDLVo4v4EeumSPwlS1PkxQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Transaction details of fraud reporting response.
    /// </summary>
    [IsoId("_VDLVpYv4EeumSPwlS1PkxQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction129 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing of the fraud reporting.
    /// </summary>
    [IsoId("_VDLVp4v4EeumSPwlS1PkxQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult19 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_VDLVqYv4EeumSPwlS1PkxQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
