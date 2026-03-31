// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates to the card issuer the level of risk associated with the transaction.
/// </summary>
[IsoId("_3jBj0EbOEeeIjf8aP9KbJA")]
[DisplayName("Risk Assessment")]
public record RiskAssessment1
{
    /// <summary>
    /// Entity providing an intermediate result of a risk assessment process.
    /// </summary>
    [IsoId("_ThO7IEbPEeeIjf8aP9KbJA")]
    [DisplayName("Risk Assessment Entity")]
    [IsoXmlTag("RskAssmntNtty")]
    public PartyIdentification200? RiskAssessmentEntity { get; init; }

    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    [IsoId("_2qiKsOCfEee9RadpHmUgYw")]
    [DisplayName("Risk Assessment Type")]
    [IsoXmlTag("RskAssmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RiskAssessmentType { get; init; }

    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_0lY4kEbPEeeIjf8aP9KbJA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public SimpleValueList<IsoMax35Text> Reason { get; init; } = [];

    /// <summary>
    /// Risk assessment result.
    /// </summary>
    [IsoId("_AwSvMEbQEeeIjf8aP9KbJA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Result { get; init; }

    /// <summary>
    /// Additional risk data associated with the transaction.
    /// </summary>
    [IsoId("_6vP9UEbQEeeIjf8aP9KbJA")]
    [DisplayName("Additional Risk Data")]
    [IsoXmlTag("AddtlRskData")]
    public ValueList<AdditionalRiskData1> AdditionalRiskData { get; init; } = [];

    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    [IsoId("_DacL0EbREeeIjf8aP9KbJA")]
    [DisplayName("Recommended Action")]
    [IsoXmlTag("RcmmnddActn")]
    public SimpleValueList<ActionType8Code> RecommendedAction { get; init; } = [];

    /// <summary>
    /// Other recommended action based on risk assessment defined at national or private level.
    /// </summary>
    [IsoId("_PWwM0EbREeeIjf8aP9KbJA")]
    [DisplayName("Other Recommended Action")]
    [IsoXmlTag("OthrRcmmnddActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherRecommendedAction { get; init; }

    /// <summary>
    /// Additional details of recommended action or other recommended action.
    /// </summary>
    [IsoId("_mYtFgOCgEee9RadpHmUgYw")]
    [DisplayName("Recommended Action Details")]
    [IsoXmlTag("RcmmnddActnDtls")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? RecommendedActionDetails { get; init; }
}
