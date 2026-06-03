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
[IsoId("_rVNPERNoEfC1ZfCQz0xB3g")]
[DisplayName("Risk Assessment4")]
public record RiskAssessment4
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_rcwBgRNoEfC1ZfCQz0xB3g")]
    [DisplayName("Entity Identification")]
    [IsoXmlTag("NttyId")]
    public IsoMax35Text? EntityIdentification { get; init; }

    /// <summary>
    /// Type of entity who assess the risk for the transaction.
    /// </summary>
    [IsoId("_rcwBgxNoEfC1ZfCQz0xB3g")]
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public ATICAPartyType1Code? EntityType { get; init; }

    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_rcwBiRNoEfC1ZfCQz0xB3g")]
    [DisplayName("Entity Country")]
    [IsoXmlTag("NttyCtry")]
    public ISO3NumericCountryCode? EntityCountry { get; init; }

    /// <summary>
    /// Type of risk assessment.
    /// </summary>
    [IsoId("_rcwBjRNoEfC1ZfCQz0xB3g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Transaction is identified as high risk.
    /// </summary>
    [IsoId("_rcwBjxNoEfC1ZfCQz0xB3g")]
    [DisplayName("High Risk Transaction")]
    [IsoXmlTag("HghRskTx")]
    public IsoTrueFalseIndicator? HighRiskTransaction { get; init; }

    /// <summary>
    /// Reason for indicating a certain level of risk for the transaction.
    /// </summary>
    [IsoId("_rcwBkRNoEfC1ZfCQz0xB3g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public SimpleValueList<IsoMax35Text> Reason { get; init; } = [];

    /// <summary>
    /// Risk assessment result.
    /// </summary>
    [IsoId("_rcwBkxNoEfC1ZfCQz0xB3g")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public IsoMax35Text? Result { get; init; }

    /// <summary>
    /// Conditions noted for the risk assessment.
    /// </summary>
    [IsoId("_rcwBlRNoEfC1ZfCQz0xB3g")]
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public IsoATICALaxProcessing? Condition { get; init; }

    /// <summary>
    /// Additional details of recommended action or other recommended action.
    /// </summary>
    [IsoId("_rcwBlxNoEfC1ZfCQz0xB3g")]
    [DisplayName("Recommendation")]
    [IsoXmlTag("Rcmmndtn")]
    public ValueList<RecommendationAction2> Recommendation { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_ZwQNEkVZEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_ZwQNE0VZEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
