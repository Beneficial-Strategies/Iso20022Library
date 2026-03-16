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
[IsoId("_hh16scSsEeuBjv5G5kw00g")]
[DisplayName("Risk Assessment")]
public record RiskAssessment2
{
    /// <summary>
    /// Entity providing an intermediate result of a risk assessment process.
    /// </summary>
    [IsoId("_hm9rQcSsEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment Entity")]
    [IsoXmlTag("RskAssmntNtty")]
    public PartyIdentification200? RiskAssessmentEntity { get; init; }

    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    [IsoId("_hm9rQ8SsEeuBjv5G5kw00g")]
    [DisplayName("Risk Assessment Type")]
    [IsoXmlTag("RskAssmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RiskAssessmentType { get; init; }

    /// <summary>
    /// Transaction is identified as high risk.
    /// </summary>
    [IsoId("_xNnQAMSsEeuBjv5G5kw00g")]
    [DisplayName("High Risk Transaction")]
    [IsoXmlTag("HghRskTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HighRiskTransaction { get; init; }

    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_hm9rRcSsEeuBjv5G5kw00g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; }

    /// <summary>
    /// Risk assessment result.
    /// </summary>
    [IsoId("_hm9rR8SsEeuBjv5G5kw00g")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Result { get; init; }

    /// <summary>
    /// Conditions noted for the risk assessment.
    /// </summary>
    [IsoId("_3xgWYMVSEeuPIIgba4mCug")]
    [DisplayName("Risk Condition")]
    [IsoXmlTag("RskCond")]
    public AdditionalData1? RiskCondition { get; init; }

    /// <summary>
    /// Additional risk data associated with the transaction.
    /// </summary>
    [IsoId("_hm9rScSsEeuBjv5G5kw00g")]
    [DisplayName("Additional Risk Data")]
    [IsoXmlTag("AddtlRskData")]
    public AdditionalRiskData1? AdditionalRiskData { get; init; }

    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    [IsoId("_hm9rS8SsEeuBjv5G5kw00g")]
    [DisplayName("Recommended Action")]
    [IsoXmlTag("RcmmnddActn")]
    public ActionType8Code? RecommendedAction { get; init; }

    /// <summary>
    /// Other recommended action based on risk assessment defined at national or private level.
    /// </summary>
    [IsoId("_hm9rTcSsEeuBjv5G5kw00g")]
    [DisplayName("Other Recommended Action")]
    [IsoXmlTag("OthrRcmmnddActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherRecommendedAction { get; init; }

    /// <summary>
    /// Additional details of recommended action or other recommended action.
    /// </summary>
    [IsoId("_hm9rT8SsEeuBjv5G5kw00g")]
    [DisplayName("Recommended Action Details")]
    [IsoXmlTag("RcmmnddActnDtls")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? RecommendedActionDetails { get; init; }
}
