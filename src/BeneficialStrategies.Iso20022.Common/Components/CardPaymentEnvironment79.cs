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
[IsoId("_BYxPIXDgEe2MCaKO5AtGsA")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment79
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
    [IsoId("_BfzrQXDgEe2MCaKO5AtGsA")]
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
    /// Third party agent which provides services.
    /// </summary>
    [IsoId("_pp-CEHDgEe2MCaKO5AtGsA")]
    [DisplayName("Service Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdr")]
    #endif
    [IsoXmlTag("SvcPrvdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer10? ServiceProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer10? ServiceProvider { get; init; } 
    #else
    public Acquirer10? ServiceProvider { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_BfzrQ3DgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrRXDgEe2MCaKO5AtGsA")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction13? POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction13? POI { get; init; } 
    #else
    public PointOfInteraction13? POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_BfzrR3DgEe2MCaKO5AtGsA")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard33? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard33? Card { get; init; } 
    #else
    public PaymentCard33? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_BfzrSXDgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrS3DgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrTXDgEe2MCaKO5AtGsA")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount3? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount3? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount3? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_BfzrT3DgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrUXDgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrU3DgEe2MCaKO5AtGsA")]
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
    [IsoId("_BfzrVXDgEe2MCaKO5AtGsA")]
    [DisplayName("Merchant Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntTkn")]
    #endif
    [IsoXmlTag("MrchntTkn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MerchantToken2? MerchantToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MerchantToken2? MerchantToken { get; init; } 
    #else
    public MerchantToken2? MerchantToken { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_BfzrV3DgEe2MCaKO5AtGsA")]
    [DisplayName("Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crdhldr")]
    #endif
    [IsoXmlTag("Crdhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cardholder20? Cardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cardholder20? Cardholder { get; init; } 
    #else
    public Cardholder20? Cardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_BfzrWXDgEe2MCaKO5AtGsA")]
    [DisplayName("Protected Cardholder Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCrdhldrData")]
    #endif
    [IsoXmlTag("PrtctdCrdhldrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType35? ProtectedCardholderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType35? ProtectedCardholderData { get; init; } 
    #else
    public ContentInformationType35? ProtectedCardholderData { get; set; } 
    #endif
    
    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_BfzrW3DgEe2MCaKO5AtGsA")]
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
