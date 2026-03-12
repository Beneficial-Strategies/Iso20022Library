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
[IsoId("_Kt26kH1DEeCF8NjrBemJWQ_-1666753734")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification35
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_KuAEgH1DEeCF8NjrBemJWQ_-1780592800")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_KuAEgX1DEeCF8NjrBemJWQ_1517302143")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType5Code? Type { get; init; } 
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_KuAEgn1DEeCF8NjrBemJWQ_520229790")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType6Code? Issuer { get; init; } 
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_KuAEg31DEeCF8NjrBemJWQ_-476842563")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
