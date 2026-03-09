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
/// Environment of the transaction.
/// </summary>
[IsoId("_59UioSpPEeuUucRY0yCMTA")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment77
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_6KyW4SpPEeuUucRY0yCMTA")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer10? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer10? Acquirer { get; init; } 
    #else
    public Acquirer10? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_6KyW4ypPEeuUucRY0yCMTA")]
    [DisplayName("Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrchnt")]
    #endif
    [IsoXmlTag("Mrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation41? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation41? Merchant { get; init; } 
    #else
    public Organisation41? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_6KyW5SpPEeuUucRY0yCMTA")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction11? POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction11? POI { get; init; } 
    #else
    public PointOfInteraction11? POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_6KyW5ypPEeuUucRY0yCMTA")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard31? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard31? Card { get; init; } 
    #else
    public PaymentCard31? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_6KyW6SpPEeuUucRY0yCMTA")]
    [DisplayName("Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chck")]
    #endif
    [IsoXmlTag("Chck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Check1? Check { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Check1? Check { get; init; } 
    #else
    public Check1? Check { get; set; } 
    #endif
    
    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_6KyW6ypPEeuUucRY0yCMTA")]
    [DisplayName("Stored Value Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcct")]
    #endif
    [IsoXmlTag("StordValAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    #else
    public StoredValueAccount2? StoredValueAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_6KyW7SpPEeuUucRY0yCMTA")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount2? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_6KyW7ypPEeuUucRY0yCMTA")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice3? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice3? CustomerDevice { get; init; } 
    #else
    public CustomerDevice3? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_6KyW8SpPEeuUucRY0yCMTA")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice3? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice3? Wallet { get; init; } 
    #else
    public CustomerDevice3? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_6KyW8ypPEeuUucRY0yCMTA")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Token1? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Token1? PaymentToken { get; init; } 
    #else
    public Token1? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant token information.
    /// </summary>
    [IsoId("_gUmRUC5HEeunNvJlR_vCbg")]
    [DisplayName("Merchant Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntTkn")]
    #endif
    [IsoXmlTag("MrchntTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MerchantToken1? MerchantToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MerchantToken1? MerchantToken { get; init; } 
    #else
    public MerchantToken1? MerchantToken { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_6KyW9SpPEeuUucRY0yCMTA")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder17? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder17? Cardholder { get; init; } 
    #else
    public Cardholder17? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_6KyW9ypPEeuUucRY0yCMTA")]
    [DisplayName("Protected Cardholder Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCrdhldrData")]
    #endif
    [IsoXmlTag("PrtctdCrdhldrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType28? ProtectedCardholderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType28? ProtectedCardholderData { get; init; } 
    #else
    public ContentInformationType28? ProtectedCardholderData { get; set; } 
    #endif
    
    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_6KyW-SpPEeuUucRY0yCMTA")]
    [DisplayName("Sale Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleEnvt")]
    #endif
    [IsoXmlTag("SaleEnvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; } 
    #else
    public RetailerSaleEnvironment2? SaleEnvironment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
