// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
[IsoId("_tcBQkRrWEeOVR9VN6fAMUg")]
[DisplayName("Adjustment")]
public partial record Adjustment6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment.
    /// </summary>
    [IsoId("_hYxEoBrXEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdjustmentType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_tzt-5xrWEeOVR9VN6fAMUg")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_tzt-6RrWEeOVR9VN6fAMUg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
