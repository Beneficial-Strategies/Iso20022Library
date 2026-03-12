// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("__mJHsWpMEeSjPYeXoHq7Ng")]
[DisplayName("Sub Account")]
public partial record SubAccount4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ABXrIWpNEeSjPYeXoHq7Ng")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification26 Identification { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_ABXrI2pNEeSjPYeXoHq7Ng")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Specifies additional properties of the account.
    /// </summary>
    [IsoId("_ABXrJWpNEeSjPYeXoHq7Ng")]
    [DisplayName("Characteristic")]
    [IsoXmlTag("Chrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Characteristic { get; init; } 
    
    
    #nullable disable
    
}
