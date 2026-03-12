// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Company in charge of a lodging establishment
/// </summary>
[IsoId("_VHhwSvcAEeiW-auGnDPZIw")]
[DisplayName("Lodging Property")]
public partial record LodgingProperty1
{
    #nullable enable
    
    /// <summary>
    /// Type of accommodations.
    /// </summary>
    [IsoId("_VHhwUvcAEeiW-auGnDPZIw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LodgingActivity1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of lodging establishment when Other National or Other Private is selected as a type code. 
    /// </summary>
    [IsoId("_VHhwT_cAEeiW-auGnDPZIw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Identifier that describes the lodging establishment as a prestigious property. 
    /// </summary>
    [IsoId("_VHhwS_cAEeiW-auGnDPZIw")]
    [DisplayName("Prestigious Property")]
    [IsoXmlTag("PrstgsPrprty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PrestigiousProperty { get; init; } 
    
    /// <summary>
    /// Name of the property.
    /// </summary>
    [IsoId("_VHhwTfcAEeiW-auGnDPZIw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the lodging company.
    /// </summary>
    [IsoId("_VHhwTvcAEeiW-auGnDPZIw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification197 Identification { get; init; } 
    
    /// <summary>
    /// Address of the property.
    /// </summary>
    [IsoId("_VHhwU_cAEeiW-auGnDPZIw")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public Location3? Location { get; init; } 
    
    /// <summary>
    /// Party in charge of assigning the identification.
    /// </summary>
    [IsoId("_VHhwUPcAEeiW-auGnDPZIw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public CompanyAssigner2Code? Assigner { get; init; } 
    
    /// <summary>
    /// Contact details at property.
    /// </summary>
    [IsoId("_VHhwTPcAEeiW-auGnDPZIw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact3? Contact { get; init; } 
    
    /// <summary>
    /// Country of the property.
    /// ISO 3166
    /// </summary>
    [IsoId("_VHhwUfcAEeiW-auGnDPZIw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the lodging facility complies with the US Hotel and Motel Fire Safety Act of 1990 (PL101-391) or similar legislation.
    /// True = in compliance
    /// False = not in compliance
    /// </summary>
    [IsoId("_w998kPcJEeiW-auGnDPZIw")]
    [DisplayName("Fire Safety Act Indicator")]
    [IsoXmlTag("FireSftyActInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FireSafetyActIndicator { get; init; } 
    
    
    #nullable disable
    
}
