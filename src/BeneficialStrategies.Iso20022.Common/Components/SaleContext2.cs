// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sale context in which the transaction is performed.
/// </summary>
[IsoId("_1piOoY0VEeWRYffwL7E13A")]
[DisplayName("Sale Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleContext2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_1z99AY0VEeWRYffwL7E13A")]
    [DisplayName("Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleId")]
    #endif
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_1z99A40VEeWRYffwL7E13A")]
    [DisplayName("Sale Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefNb")]
    #endif
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceNumber { get; init; } 
    #else
    public System.String? SaleReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_1z99BY0VEeWRYffwL7E13A")]
    [DisplayName("Sale Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRcncltnId")]
    #endif
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReconciliationIdentification { get; init; } 
    #else
    public System.String? SaleReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_1z99B40VEeWRYffwL7E13A")]
    [DisplayName("Cashier Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshrId")]
    #endif
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashierIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashierIdentification { get; init; } 
    #else
    public System.String? CashierIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_1z99CY0VEeWRYffwL7E13A")]
    [DisplayName("Shift Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShftNb")]
    #endif
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShiftNumber { get; init; } 
    #else
    public System.String? ShiftNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the purchase order.
    /// </summary>
    [IsoId("_m9lbcJXEEeWr_-S5OCtcIg")]
    [DisplayName("Purchase Order Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrNb")]
    #endif
    [IsoXmlTag("PurchsOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PurchaseOrderNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PurchaseOrderNumber { get; init; } 
    #else
    public System.String? PurchaseOrderNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the invoice.
    /// </summary>
    [IsoId("_sp3BwJXEEeWr_-S5OCtcIg")]
    [DisplayName("Invoice Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcNb")]
    #endif
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InvoiceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvoiceNumber { get; init; } 
    #else
    public System.String? InvoiceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification allocated by the sale system and given to the customer.
    /// </summary>
    [IsoId("_zm_zAJXEEeWr_-S5OCtcIg")]
    [DisplayName("Delivery Note Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryNoteNb")]
    #endif
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryNoteNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryNoteNumber { get; init; } 
    #else
    public System.String? DeliveryNoteNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    [IsoId("_93rfUI0WEeWRYffwL7E13A")]
    [DisplayName("Sponsored Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpnsrdMrchnt")]
    #endif
    [IsoXmlTag("SpnsrdMrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation26? SponsoredMerchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation26? SponsoredMerchant { get; init; } 
    #else
    public Organisation26? SponsoredMerchant { get; set; } 
    #endif
    
    /// <summary>
    /// True if the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_HCLgAI0XEeWRYffwL7E13A")]
    [DisplayName("Split Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltPmt")]
    #endif
    [IsoXmlTag("SpltPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SplitPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SplitPayment { get; init; } 
    #else
    public System.String? SplitPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining amount to complete the sale transaction, if a partial payment has been completed for the sale transaction.
    /// </summary>
    [IsoId("_L-uSgI0XEeWRYffwL7E13A")]
    [DisplayName("Remaining Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngAmt")]
    #endif
    [IsoXmlTag("RmngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? RemainingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? RemainingAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? RemainingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information associated with the sale transaction.
    /// </summary>
    [IsoId("_1z99C40VEeWRYffwL7E13A")]
    [DisplayName("Additional Sale Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSaleData")]
    #endif
    [IsoXmlTag("AddtlSaleData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalSaleData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalSaleData { get; init; } 
    #else
    public System.String? AdditionalSaleData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
