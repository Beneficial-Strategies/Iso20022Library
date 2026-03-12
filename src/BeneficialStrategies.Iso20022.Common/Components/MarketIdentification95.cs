// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on a trading venue as per ISO 10383.
/// </summary>
[IsoId("_Q8VpYS6mEeiLE6ldFr13hQ")]
[DisplayName("Market Identification")]
public partial record MarketIdentification95
{
    #nullable enable
    
    /// <summary>
    /// Operating MIC of the venue.
    /// </summary>
    [IsoId("_RLF3ES6mEeiLE6ldFr13hQ")]
    [DisplayName("Operating")]
    [IsoXmlTag("Oprg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Operating { get; init; } 
    
    /// <summary>
    /// Segment MIC of the venue where it exists, otherwise the Operating MIC.
    /// </summary>
    [IsoId("_RLF3Ey6mEeiLE6ldFr13hQ")]
    [DisplayName("Segment")]
    [IsoXmlTag("Sgmt")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier Segment { get; init; } 
    
    /// <summary>
    /// Define the type of Market Identification Code that is being supplied.
    /// </summary>
    [IsoId("_RLF3FS6mEeiLE6ldFr13hQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarketIdentification1Code Type { get; init; } 
    
    /// <summary>
    /// Provides the category of market the venue operates in.
    /// </summary>
    [IsoId("_RLF3Fy6mEeiLE6ldFr13hQ")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public MICEntityType1Code? Category { get; init; } 
    
    /// <summary>
    /// The name or description of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3GS6mEeiLE6ldFr13hQ")]
    [DisplayName("Institution Name")]
    [IsoXmlTag("InstnNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    public required IsoMax450Text InstitutionName { get; init; } 
    
    /// <summary>
    /// Known acronym of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3Gy6mEeiLE6ldFr13hQ")]
    [DisplayName("Acronym")]
    [IsoXmlTag("Acrnm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Acronym { get; init; } 
    
    /// <summary>
    /// City where the institution, market, or infrastructure operates.
    /// </summary>
    [IsoId("_RLF3HS6mEeiLE6ldFr13hQ")]
    [DisplayName("City")]
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? City { get; init; } 
    
    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    [IsoId("_RLF3Hy6mEeiLE6ldFr13hQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCodeAndName3 Country { get; init; } 
    
    /// <summary>
    /// The name of the national competent authority associated with the MIC.
    /// </summary>
    [IsoId("_RLF3IS6mEeiLE6ldFr13hQ")]
    [DisplayName("Authority Name")]
    [IsoXmlTag("AuthrtyNm")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    public IsoMax450Text? AuthorityName { get; init; } 
    
    /// <summary>
    /// Website URI of the institution, market, or infrastructure.
    /// </summary>
    [IsoId("_RLF3Iy6mEeiLE6ldFr13hQ")]
    [DisplayName("Web Site")]
    [IsoXmlTag("WebSite")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? WebSite { get; init; } 
    
    /// <summary>
    /// Details additional information about the market operator.
    /// </summary>
    [IsoId("_RLF3JS6mEeiLE6ldFr13hQ")]
    [DisplayName("Note")]
    [IsoXmlTag("Note")]
    [IsoSimpleType(IsoSimpleType.Max450Text)]
    [StringLength(maximumLength: 450 ,MinimumLength = 1)]
    public IsoMax450Text? Note { get; init; } 
    
    /// <summary>
    /// Additional information to help users identify the exchange or understand a modification.
    /// </summary>
    [IsoId("_RLF3Jy6mEeiLE6ldFr13hQ")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public Modification1Code? Modification { get; init; } 
    
    /// <summary>
    /// First date of the MIC issuance.
    /// </summary>
    [IsoId("_RLF3KS6mEeiLE6ldFr13hQ")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CreationDate { get; init; } 
    
    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_RLF3Ky6mEeiLE6ldFr13hQ")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public required Period4Choice_ ValidityPeriod { get; init; } 
    
    /// <summary>
    /// Date when the market identification code was last modified.
    /// </summary>
    [IsoId("_RLF3LS6mEeiLE6ldFr13hQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StatusDate { get; init; } 
    
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_RLF3Ly6mEeiLE6ldFr13hQ")]
    [DisplayName("Last Updated Date")]
    [IsoXmlTag("LastUpdtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastUpdatedDate { get; init; } 
    
    
    #nullable disable
    
}
