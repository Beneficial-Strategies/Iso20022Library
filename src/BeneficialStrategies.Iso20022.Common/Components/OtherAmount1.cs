// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount pertaining to a transaction.
/// </summary>
[IsoId("_JgF9kImPEeeJpL7HBafurA")]
[DisplayName("Other Amount")]
public partial record OtherAmount1
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_Ybg0AImPEeeJpL7HBafurA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OtherAmountType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Currency and amount.
    /// </summary>
    [IsoId("_d_97EYmPEeeJpL7HBafurA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
