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
[IsoId("_n3oMMRrcEeOVR9VN6fAMUg")]
[DisplayName("Adjustment")]
public partial record Adjustment7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment.
    /// </summary>
    [IsoId("_oP6wYRrcEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdjustmentType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount or rate of the adjustment.
    /// </summary>
    [IsoId("_oP6wZRrcEeOVR9VN6fAMUg")]
    [DisplayName("Amount Or Percentage")]
    [IsoXmlTag("AmtOrPctg")]
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_oP6wYxrcEeOVR9VN6fAMUg")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    
    #nullable disable
    
}
