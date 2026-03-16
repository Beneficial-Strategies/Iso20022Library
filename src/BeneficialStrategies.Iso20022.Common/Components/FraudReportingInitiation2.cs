// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  fraud reporting initiation message.
/// </summary>
[IsoId("_D-81EYv3EeumSPwlS1PkxQ")]
[DisplayName("Fraud Reporting Initiation")]
public record FraudReportingInitiation2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_EFLY4Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment28 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_EFLY44v3EeumSPwlS1PkxQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_EFLY5Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction130 Transaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_EFLY54v3EeumSPwlS1PkxQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_EFLY6Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
