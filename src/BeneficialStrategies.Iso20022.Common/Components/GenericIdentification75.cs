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
[IsoId("_ZKK0AXtCEeSTS7uHCe8FPQ")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification75
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_ZW5ocXtCEeSTS7uHCe8FPQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_ZW5oc3tCEeSTS7uHCe8FPQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType11Code Type { get; init; } 
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_ZW5odXtCEeSTS7uHCe8FPQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType9Code? Issuer { get; init; } 
    
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_ZW5od3tCEeSTS7uHCe8FPQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; } 
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_ZW5oeXtCEeSTS7uHCe8FPQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
