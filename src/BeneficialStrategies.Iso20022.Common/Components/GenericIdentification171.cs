// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity.
/// </summary>
[IsoId("_8J9CAdj7EeiojJsa6FYyew")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification171
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_8UBkAdj7EeiojJsa6FYyew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_8UBkA9j7EeiojJsa6FYyew")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType3Code? Type { get; init; } 
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_8UBkBdj7EeiojJsa6FYyew")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType4Code? Issuer { get; init; } 
    
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_8UBkB9j7EeiojJsa6FYyew")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; } 
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_8UBkCdj7EeiojJsa6FYyew")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    [IsoId("_8UBkC9j7EeiojJsa6FYyew")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters5? RemoteAccess { get; init; } 
    
    /// <summary>
    /// Location of the entity.
    /// </summary>
    [IsoId("_95NcUNj_EeiojJsa6FYyew")]
    [DisplayName("Geolocation")]
    [IsoXmlTag("Glctn")]
    public Geolocation1? Geolocation { get; init; } 
    
    
    #nullable disable
    
}
