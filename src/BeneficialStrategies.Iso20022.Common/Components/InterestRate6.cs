// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on interest rates related to the transaction.
/// </summary>
[IsoId("_oLE7E8g6Eeu4ecZgAYuz5w")]
[DisplayName("Interest Rate")]
public partial record InterestRate6
{
    #nullable enable
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_oMi6ocg6Eeu4ecZgAYuz5w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection53 Amount { get; init; } 
    
    /// <summary>
    /// Information on interest rates related to the transaction.
    /// </summary>
    [IsoId("_oMi6o8g6Eeu4ecZgAYuz5w")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public required InterestRate27Choice_ InterestRate { get; init; } 
    
    
    #nullable disable
    
}
