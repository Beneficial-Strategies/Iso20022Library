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
[IsoId("_a-l5UY4CEeWrZqsymMFdfg")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification93
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_bJ9b0Y4CEeWrZqsymMFdfg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_bJ9b044CEeWrZqsymMFdfg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType6Code? Issuer { get; init; } 
    
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_bJ9b1Y4CEeWrZqsymMFdfg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; } 
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_bJ9b144CEeWrZqsymMFdfg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    [IsoId("_jhvmII4CEeWrZqsymMFdfg")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters5? RemoteAccess { get; init; } 
    
    
    #nullable disable
    
}
