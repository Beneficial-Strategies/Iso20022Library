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
[IsoId("_mmNwMYYEEemxIqbaFEE8-w")]
[DisplayName("Card Acquisition Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAcquisitionRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card payment brands allowed by the Sale System for the payment transaction.
    /// </summary>
    [IsoId("_mxLDAYYEEemxIqbaFEE8-w")]
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
    [IsoId("_mxLDA4YEEemxIqbaFEE8-w")]
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
    [IsoId("_mxLDBYYEEemxIqbaFEE8-w")]
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
    [IsoId("_mxLDB4YEEemxIqbaFEE8-w")]
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
    [IsoId("_mxLDCYYEEemxIqbaFEE8-w")]
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
    [IsoId("_mxLDC4YEEemxIqbaFEE8-w")]
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
    [IsoId("_kR1Sw4YEEemxIqbaFEE8-w")]
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
    [IsoId("_kR1SxIYEEemxIqbaFEE8-w")]
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
    [IsoId("_kR1SxYYEEemxIqbaFEE8-w")]
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
