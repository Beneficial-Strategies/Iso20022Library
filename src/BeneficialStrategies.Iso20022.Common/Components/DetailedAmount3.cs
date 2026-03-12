// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_Y-fwE_wLEeGHDMP28rpT3g_-1514769402")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount3
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_Y-fwFPwLEeGHDMP28rpT3g_-750703704")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount2Code Type { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_Y-fwFfwLEeGHDMP28rpT3g_723131194")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ActiveCurrencyAndAmount Value { get; init; } 
    
    
    #nullable disable
    
}
