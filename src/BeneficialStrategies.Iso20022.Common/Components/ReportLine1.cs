// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a purchase order.
/// </summary>
[IsoId("_ToDCydp-Ed-ak6NoX_4Aeg_-314950341")]
[DisplayName("Report Line")]
public partial record ReportLine1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    [IsoId("_ToMMsNp-Ed-ak6NoX_4Aeg_-80376411")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction.
    /// </summary>
    [IsoId("_ToMMsdp-Ed-ak6NoX_4Aeg_-1126725260")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    [IsoId("_ToMMstp-Ed-ak6NoX_4Aeg_-43433619")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Total amount of the purchase order after taxes, adjustments and charges.
    /// </summary>
    [IsoId("_ToMMs9p-Ed-ak6NoX_4Aeg_203143575")]
    [DisplayName("Purchase Order Total Net Amount")]
    [IsoXmlTag("PurchsOrdrTtlNetAmt")]
    public required CurrencyAndAmount PurchaseOrderTotalNetAmount { get; init; } 
    
    /// <summary>
    /// Accumulated net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_ToMMtNp-Ed-ak6NoX_4Aeg_289031555")]
    [DisplayName("Accumulated Net Amount")]
    [IsoXmlTag("AcmltdNetAmt")]
    public required CurrencyAndAmount AccumulatedNetAmount { get; init; } 
    
    
    #nullable disable
    
}
