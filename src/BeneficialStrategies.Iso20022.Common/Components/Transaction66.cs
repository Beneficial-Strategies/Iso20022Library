// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the payment transaction.
/// </summary>
[IsoId("_XFBYt249EeiU9cctagi5ow")]
[DisplayName("Transaction")]
public partial record Transaction66
{
    #nullable enable
    
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_XO_0F249EeiU9cctagi5ow")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public System2? PaymentTo { get; init; } 
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_XO_0GW49EeiU9cctagi5ow")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public System2? PaymentFrom { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment transaction is a debit or credit transaction. |.
    /// </summary>
    [IsoId("_XO_0G249EeiU9cctagi5ow")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
    /// </summary>
    [IsoId("_XO_0HW49EeiU9cctagi5ow")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public PaymentInstruction32? Payment { get; init; } 
    
    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_XO_0H249EeiU9cctagi5ow")]
    [DisplayName("Account Entry")]
    [IsoXmlTag("AcctNtry")]
    public CashAccountAndEntry3? AccountEntry { get; init; } 
    
    /// <summary>
    /// Provides the references of the underlying securities transaction.
    /// </summary>
    [IsoId("_XO_0IW49EeiU9cctagi5ow")]
    [DisplayName("Securities Transaction References")]
    [IsoXmlTag("SctiesTxRefs")]
    public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
    
    
    #nullable disable
    
}
