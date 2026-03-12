// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Request message.
/// </summary>
[IsoId("_vaJ1cU4AEey_VecAUE-C9Q")]
[DisplayName("Balance Inquiry Request")]
public partial record BalanceInquiryRequest5
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_9XrToU7ZEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_vgef4U4AEey_VecAUE-C9Q")]
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    
    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_vgef404AEey_VecAUE-C9Q")]
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest3? LoyaltyAccountRequest { get; init; } 
    
    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_vgfG8U4AEey_VecAUE-C9Q")]
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest5? StoredValueAccountRequest { get; init; } 
    
    
    #nullable disable
    
}
