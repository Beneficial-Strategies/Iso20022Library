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
[IsoId("_n9i-QYX-EemxIqbaFEE8-w")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment73
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
    [IsoId("_oH7pUYX-EemxIqbaFEE8-w")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer9? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer9? Acquirer { get; init; } 
    #else
    public Acquirer9? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_oH7pU4X-EemxIqbaFEE8-w")]
    [DisplayName("Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrchnt")]
    #endif
    [IsoXmlTag("Mrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation32? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation32? Merchant { get; init; } 
    #else
    public Organisation32? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_oH7pVYX-EemxIqbaFEE8-w")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction9? POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction9? POI { get; init; } 
    #else
    public PointOfInteraction9? POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_oH7pV4X-EemxIqbaFEE8-w")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard28? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard28? Card { get; init; } 
    #else
    public PaymentCard28? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_oH7pWYX-EemxIqbaFEE8-w")]
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
    [IsoId("_oH7pW4X-EemxIqbaFEE8-w")]
    [DisplayName("Stored Value Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcct")]
    #endif
    [IsoXmlTag("StordValAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccount1? StoredValueAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccount1? StoredValueAccount { get; init; } 
    #else
    public StoredValueAccount1? StoredValueAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_oH7pXYX-EemxIqbaFEE8-w")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount1? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount1? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_oH7pX4X-EemxIqbaFEE8-w")]
    [DisplayName("Customer Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDvc")]
    #endif
    [IsoXmlTag("CstmrDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? CustomerDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? CustomerDevice { get; init; } 
    #else
    public CustomerDevice1? CustomerDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_oH7pYYX-EemxIqbaFEE8-w")]
    [DisplayName("Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wllt")]
    #endif
    [IsoXmlTag("Wllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDevice1? Wallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDevice1? Wallet { get; init; } 
    #else
    public CustomerDevice1? Wallet { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_oH7pY4X-EemxIqbaFEE8-w")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken4? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken4? PaymentToken { get; init; } 
    #else
    public CardPaymentToken4? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_oH7pZYX-EemxIqbaFEE8-w")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder14? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder14? Cardholder { get; init; } 
    #else
    public Cardholder14? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_oH7pZ4X-EemxIqbaFEE8-w")]
    [DisplayName("Protected Cardholder Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCrdhldrData")]
    #endif
    [IsoXmlTag("PrtctdCrdhldrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType17? ProtectedCardholderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType17? ProtectedCardholderData { get; init; } 
    #else
    public ContentInformationType17? ProtectedCardholderData { get; set; } 
    #endif
    
    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_oH7paYX-EemxIqbaFEE8-w")]
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
