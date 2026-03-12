// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates one of the constraints of a range of business values.
/// </summary>
[IsoId("_Q7yQ0dp-Ed-ak6NoX_4Aeg_528848853")]
[DisplayName("Term")]
public partial record Term1
{
    #nullable enable
    
    /// <summary>
    /// Provides the relationship between a variable and a fixed value.
    /// </summary>
    [IsoId("_Q7yQ0tp-Ed-ak6NoX_4Aeg_-1511433825")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operator1Code Operator { get; init; } 
    
    /// <summary>
    /// Indicates the value.
    /// </summary>
    [IsoId("_Q7yQ09p-Ed-ak6NoX_4Aeg_1365947131")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required RateOrAbsoluteValue1Choice_ Value { get; init; } 
    
    
    #nullable disable
    
}
