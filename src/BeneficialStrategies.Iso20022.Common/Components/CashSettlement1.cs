// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash settlement parties and accounts.
/// </summary>
[IsoId("_F6-JkCCpEeWJd9HF2tO7BA")]
[DisplayName("Cash Settlement")]
public partial record CashSettlement1
{
    #nullable enable
    
    /// <summary>
    /// Account to credit or debit. When this is an account to debit, this is for the payment of a subscription to an investment fund, a savings plan payment, the purchase of securities or the payment of charges. When this is an account to credit, this is for the payment of an amount as a result of a redemption of investment fund units, the sale of securities, interest and dividend payments. A single account may be specified for all cash movements on the account or cash accounts may be specified for specific types of transactions on the account.
    /// </summary>
    [IsoId("_XPN4kCCpEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Details")]
    [IsoXmlTag("CshAcctDtls")]
    public CashAccount33? CashAccountDetails { get; init; } 
    
    /// <summary>
    /// Method of payment other than a cash account.
    /// </summary>
    [IsoId("_aQxlECCpEeWJd9HF2tO7BA")]
    [DisplayName("Other Cash Settlement Details")]
    [IsoXmlTag("OthrCshSttlmDtls")]
    public PaymentInstrument13? OtherCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
