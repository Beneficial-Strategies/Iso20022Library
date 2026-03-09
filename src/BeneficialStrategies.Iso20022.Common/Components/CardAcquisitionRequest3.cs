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
/// Data to request to card data acquisition.
/// </summary>
[IsoId("_C7LjAU7bEeyGi9JAv6wq7Q")]
[DisplayName("Card Acquisition Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAcquisitionRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_q9vScU7aEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment brands allowed by the Sale System for the payment transaction.
    /// </summary>
    [IsoId("_DCr5MU7bEeyGi9JAv6wq7Q")]
    [DisplayName("Allowed Payment Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdPmtBrnd")]
    #endif
    [IsoXmlTag("AllwdPmtBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AllowedPaymentBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllowedPaymentBrand { get; init; } 
    #else
    public System.String? AllowedPaymentBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty brands or programs allowed by the Sale System for the loyalty transaction.
    /// </summary>
    [IsoId("_DCr5M07bEeyGi9JAv6wq7Q")]
    [DisplayName("Allowed Loyalty Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdLltyBrnd")]
    #endif
    [IsoXmlTag("AllwdLltyBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AllowedLoyaltyBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllowedLoyaltyBrand { get; init; } 
    #else
    public System.String? AllowedLoyaltyBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the Customer realises the selection of the card application.
    /// </summary>
    [IsoId("_DCr5NU7bEeyGi9JAv6wq7Q")]
    [DisplayName("Force Customer Selection Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ForceCstmrSelctnFlg")]
    #endif
    [IsoXmlTag("ForceCstmrSelctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ForceCustomerSelectionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForceCustomerSelectionFlag { get; init; } 
    #else
    public System.String? ForceCustomerSelectionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction. It allows the processing of a contactless card.
    /// </summary>
    [IsoId("_DCr5N07bEeyGi9JAv6wq7Q")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_DCr5OU7bEeyGi9JAv6wq7Q")]
    [DisplayName("Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTp")]
    #endif
    [IsoXmlTag("PmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType13Code? PaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType13Code? PaymentType { get; init; } 
    #else
    public CardPaymentServiceType13Code? PaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if Cashback is allowed
    /// </summary>
    [IsoId("_DCr5O07bEeyGi9JAv6wq7Q")]
    [DisplayName("Cash Back Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBckFlg")]
    #endif
    [IsoXmlTag("CshBckFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CashBackFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashBackFlag { get; init; } 
    #else
    public System.String? CashBackFlag { get; set; } 
    #endif
    
    /// <summary>
    /// The POI System receives this information.
    /// </summary>
    [IsoId("_DCr5PU7bEeyGi9JAv6wq7Q")]
    [DisplayName("Sale To POI Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleToPOIData")]
    #endif
    [IsoXmlTag("SaleToPOIData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SaleToPOIData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleToPOIData { get; init; } 
    #else
    public System.String? SaleToPOIData { get; set; } 
    #endif
    
    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    [IsoId("_DCr5P07bEeyGi9JAv6wq7Q")]
    [DisplayName("Sale To Acquirer Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleToAcqrrData")]
    #endif
    [IsoXmlTag("SaleToAcqrrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SaleToAcquirerData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleToAcquirerData { get; init; } 
    #else
    public System.String? SaleToAcquirerData { get; set; } 
    #endif
    
    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    [IsoId("_DCr5QU7bEeyGi9JAv6wq7Q")]
    [DisplayName("Sale To Issuer Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleToIssrData")]
    #endif
    [IsoXmlTag("SaleToIssrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SaleToIssuerData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleToIssuerData { get; init; } 
    #else
    public System.String? SaleToIssuerData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
