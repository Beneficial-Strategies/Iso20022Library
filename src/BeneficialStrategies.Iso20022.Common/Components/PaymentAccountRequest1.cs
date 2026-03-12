// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the account pointed by the payment card.
/// </summary>
[IsoId("_TIjQcNuIEeiB5uLfkg9ZJA")]
[DisplayName("Payment Account Request")]
public partial record PaymentAccountRequest1
{
    #nullable enable
    
    /// <summary>
    /// Type of cardholder account used for the transaction. By Default the code Default is taken into account.
    /// </summary>
    [IsoId("_f2VKoNuIEeiB5uLfkg9ZJA")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; } 
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_kfpfINuIEeiB5uLfkg9ZJA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    /// <summary>
    /// Reference of an account (all types).
    /// </summary>
    [IsoId("_n-WaoNuIEeiB5uLfkg9ZJA")]
    [DisplayName("Account Reference")]
    [IsoXmlTag("AcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountReference { get; init; } 
    
    
    #nullable disable
    
}
