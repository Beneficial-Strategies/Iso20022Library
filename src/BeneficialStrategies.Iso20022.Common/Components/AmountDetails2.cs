// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_9ycDoZJFEeuuktRxxQZoNQ")]
[DisplayName("Amount Details")]
public partial record AmountDetails2
{
    #nullable enable
    
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_94tDsZJFEeuuktRxxQZoNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeOfAmount20Code? Type { get; init; } 
    
    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    [IsoId("_94tDs5JFEeuuktRxxQZoNQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_94tDtZJFEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_tcjHUTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_94tDuZJFEeuuktRxxQZoNQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; } 
    
    
    #nullable disable
    
}
