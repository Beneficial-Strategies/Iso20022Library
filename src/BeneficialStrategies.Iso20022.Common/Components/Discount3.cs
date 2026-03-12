// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of a discount applied to the transaction. 
/// </summary>
[IsoId("_B66xo_S0Eeife6veM7daYw")]
[DisplayName("Discount")]
public partial record Discount3
{
    #nullable enable
    
    /// <summary>
    /// Describes the type of discount applied to the transaction.
    /// </summary>
    [IsoId("_B67YsPS0Eeife6veM7daYw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Monetary value of the discount applied to the transaction.
    /// </summary>
    [IsoId("_B66xpPS0Eeife6veM7daYw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Value { get; init; } 
    
    
    #nullable disable
    
}
