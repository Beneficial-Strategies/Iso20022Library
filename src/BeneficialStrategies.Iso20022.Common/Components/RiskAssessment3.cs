// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk Assessment3.
/// </summary>
[IsoId("_Io6h4XG7Ee60F8I8TAMKmg")]
[DisplayName("Risk Assessment3")]
public record RiskAssessment3
{
    /// <summary>
    /// Entity Identification.
    /// </summary>
    [DisplayName("Entity Identification")]
    [IsoXmlTag("NttyId")]
    public Max35Text? EntityIdentification { get; init; }

    /// <summary>
    /// Entity Type.
    /// </summary>
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public PartyType28Code? EntityType { get; init; }

    /// <summary>
    /// Other Entity Type.
    /// </summary>
    [DisplayName("Other Entity Type")]
    [IsoXmlTag("OthrNttyTp")]
    public Max35Text? OtherEntityType { get; init; }

    /// <summary>
    /// Entity Assigner.
    /// </summary>
    [DisplayName("Entity Assigner")]
    [IsoXmlTag("NttyAssgnr")]
    public PartyType18Code? EntityAssigner { get; init; }

    /// <summary>
    /// Entity Country.
    /// </summary>
    [DisplayName("Entity Country")]
    [IsoXmlTag("NttyCtry")]
    public ISO3NumericCountryCode? EntityCountry { get; init; }

    /// <summary>
    /// Entity Short Name.
    /// </summary>
    [DisplayName("Entity Short Name")]
    [IsoXmlTag("NttyShrtNm")]
    public Max35Text? EntityShortName { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public Max35Text? Type { get; init; }

    /// <summary>
    /// High Risk Transaction.
    /// </summary>
    [DisplayName("High Risk Transaction")]
    [IsoXmlTag("HghRskTx")]
    public TrueFalseIndicator? HighRiskTransaction { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<Max35Text> Reason { get; init; } = [];

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Max35Text? Result { get; init; }

    /// <summary>
    /// Condition.
    /// </summary>
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public ValueList<AdditionalData1> Condition { get; init; } = [];

    /// <summary>
    /// Recommendation.
    /// </summary>
    [DisplayName("Recommendation")]
    [IsoXmlTag("Rcmmndtn")]
    public ValueList<RecommendationAction1> Recommendation { get; init; } = [];

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalRiskData1> AdditionalData { get; init; } = [];
}
