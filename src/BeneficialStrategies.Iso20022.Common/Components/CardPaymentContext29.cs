// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[IsoId("_xnQKcU6VEeyGi9JAv6wq7Q")]
[DisplayName("Card Payment Context")]
public partial record CardPaymentContext29
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_xubwgU6VEeyGi9JAv6wq7Q")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext28? PaymentContext { get; init; } 
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_xubwg06VEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext4? SaleContext { get; init; } 
    
    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_xubwhU6VEeyGi9JAv6wq7Q")]
    [DisplayName("Direct Debit Context")]
    [IsoXmlTag("DrctDbtCntxt")]
    public CardDirectDebit2? DirectDebitContext { get; init; } 
    
    
    #nullable disable
    
}
