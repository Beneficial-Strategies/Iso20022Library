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
[IsoId("_SkxHrQEcEeCQm6a_G2yO_w_185187178")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification33
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_SkxHrgEcEeCQm6a_G2yO_w_71348112")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_SkxHrwEcEeCQm6a_G2yO_w_-925724241")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType3Code Type { get; init; } 
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_Sk6RkAEcEeCQm6a_G2yO_w_-1922796594")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType4Code? Issuer { get; init; } 
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_Sk6RkQEcEeCQm6a_G2yO_w_1375098349")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
