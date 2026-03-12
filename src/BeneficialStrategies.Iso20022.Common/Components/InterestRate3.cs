// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between a fixed rate and a floating rate.
/// </summary>
[IsoId("_g9tac6x2Eem81-uIvTF5rQ")]
[DisplayName("Interest Rate")]
public partial record InterestRate3
{
    #nullable enable
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_hBu-wax2Eem81-uIvTF5rQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection53 Amount { get; init; } 
    
    /// <summary>
    /// Information on interest rates related to the transaction.
    /// </summary>
    [IsoId("_hBu-w6x2Eem81-uIvTF5rQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public required InterestRate20Choice_ InterestRate { get; init; } 
    
    
    #nullable disable
    
}
