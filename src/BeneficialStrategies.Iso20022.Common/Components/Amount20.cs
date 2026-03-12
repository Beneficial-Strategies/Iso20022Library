// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains amount details for a specific type of charge.
/// </summary>
[IsoId("_G0wQQTarEeyjpIf0r_Ojqw")]
[DisplayName("Amount")]
public partial record Amount20
{
    #nullable enable
    
    /// <summary>
    /// Type of telephone charge.
    /// </summary>
    [IsoId("_G6RCYTarEeyjpIf0r_Ojqw")]
    [DisplayName("Type Of Charge")]
    [IsoXmlTag("TpOfChrg")]
    public TypeOfAmount19Code? TypeOfCharge { get; init; } 
    
    /// <summary>
    /// Description of other type of charge.
    /// </summary>
    [IsoId("_G6RCYzarEeyjpIf0r_Ojqw")]
    [DisplayName("Other Type Of Charge")]
    [IsoXmlTag("OthrTpOfChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherTypeOfCharge { get; init; } 
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_G6RCZTarEeyjpIf0r_Ojqw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_nIX-ETaqEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    
    #nullable disable
    
}
