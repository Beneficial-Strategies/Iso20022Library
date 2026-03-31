// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a trading venue as per ISO 10383.
/// </summary>
[IsoId("_BP5vEX5sEeasY4u9QTizPQ")]
[DisplayName("Market Identification")]
public record MarketIdentification92
{
    /// <summary>
    /// Operating MIC of the venue.
    /// </summary>
    [IsoId("_Bc_v4X5sEeasY4u9QTizPQ")]
    [DisplayName("Operating")]
    [IsoXmlTag("Oprg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Operating { get; init; }

    /// <summary>
    /// Segment MIC of the venue where it exists, otherwise the Operating MIC.
    /// </summary>
    [IsoId("_Bc_v435sEeasY4u9QTizPQ")]
    [DisplayName("Segment")]
    [IsoXmlTag("Sgmt")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Segment { get; init; }

    /// <summary>
    /// Define the type of Market Identification Code that is being supplied.
    /// </summary>
    [IsoId("_Bc_v5X5sEeasY4u9QTizPQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarketIdentification1Code Type { get; init; }

    /// <summary>
    /// Provides the category of market the venue operates in.
    /// </summary>
    [IsoId("_Bc_v535sEeasY4u9QTizPQ")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public TradingVenue1Code? Category { get; init; }

    /// <summary>
    /// The name or description of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_Bc_v6X5sEeasY4u9QTizPQ")]
    [DisplayName("Institution Name")]
    [IsoXmlTag("InstnNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450, MinimumLength = 1)]
    public required IsoMax450Text InstitutionName { get; init; }

    /// <summary>
    /// Known acronym of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_Bc_v635sEeasY4u9QTizPQ")]
    [DisplayName("Acronym")]
    [IsoXmlTag("Acrnm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Acronym { get; init; }

    /// <summary>
    /// City where the institution, market, or infrastructure operates.
    /// </summary>
    [IsoId("_Bc_v7X5sEeasY4u9QTizPQ")]
    [DisplayName("City")]
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? City { get; init; }

    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    [IsoId("_Bc_v735sEeasY4u9QTizPQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCodeAndName3 Country { get; init; }

    /// <summary>
    /// The name of the national competent authority associated with the MIC.
    /// </summary>
    [IsoId("_Bc_v8X5sEeasY4u9QTizPQ")]
    [DisplayName("Authority Name")]
    [IsoXmlTag("AuthrtyNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450, MinimumLength = 1)]
    public IsoMax450Text? AuthorityName { get; init; }

    /// <summary>
    /// Website URI of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_Bc_v835sEeasY4u9QTizPQ")]
    [DisplayName("Web Site")]
    [IsoXmlTag("WebSite")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? WebSite { get; init; }

    /// <summary>
    /// Details additional information about the market operator.
    /// </summary>
    [IsoId("_Bc_v9X5sEeasY4u9QTizPQ")]
    [DisplayName("Note")]
    [IsoXmlTag("Note")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450, MinimumLength = 1)]
    public IsoMax450Text? Note { get; init; }

    /// <summary>
    /// Additional information to help users identify the exchange or understand a modification.
    /// </summary>
    [IsoId("_Bc_v935sEeasY4u9QTizPQ")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public Modification1Code? Modification { get; init; }

    /// <summary>
    /// First date of the MIC issuance.
    /// </summary>
    [IsoId("_Bc_v-X5sEeasY4u9QTizPQ")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CreationDate { get; init; }

    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_Bc_v-35sEeasY4u9QTizPQ")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public required Period4Choice_ ValidityPeriod { get; init; }

    /// <summary>
    /// Date when the market identification code was last modified.
    /// </summary>
    [IsoId("_Bc_v_X5sEeasY4u9QTizPQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StatusDate { get; init; }

    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_Bc_v_35sEeasY4u9QTizPQ")]
    [DisplayName("Last Updated Date")]
    [IsoXmlTag("LastUpdtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastUpdatedDate { get; init; }
}
