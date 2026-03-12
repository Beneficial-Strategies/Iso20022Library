// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price with notation.
/// </summary>
[IsoId("_U2lWUZjgEeqkLZLH6DK3UQ")]
[DisplayName("Securities Transaction Price")]
public partial record SecuritiesTransactionPrice5
{
    #nullable enable
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_U3LMM5jgEeqkLZLH6DK3UQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? Value { get; init; } 
    
    /// <summary>
    /// Notation of the price.
    /// </summary>
    [IsoId("_U3LMNZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    
    #nullable disable
    
}
