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
/// Context of the sale involved in a card transaction.
/// </summary>
[IsoId("_GejwcShKEeyhZIgCcGlTyA")]
[DisplayName("Sale Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleContext8
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
    [IsoId("_GknVIShKEeyhZIgCcGlTyA")]
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
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_GknVIyhKEeyhZIgCcGlTyA")]
    [DisplayName("Sale Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefId")]
    #endif
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceIdentification { get; init; } 
    #else
    public System.String? SaleReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_GknVJShKEeyhZIgCcGlTyA")]
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
    /// Type of goods and/or services.
    /// </summary>
    [IsoId("_GknVJyhKEeyhZIgCcGlTyA")]
    [DisplayName("Goods And Services Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodsAndSvcsTp")]
    #endif
    [IsoXmlTag("GoodsAndSvcsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; } 
    #else
    public GoodsAndServices1Code? GoodsAndServicesType { get; set; } 
    #endif
    
    /// <summary>
    /// Sub type of goods and/or services.
    /// </summary>
    [IsoId("_GknVKShKEeyhZIgCcGlTyA")]
    [DisplayName("Good And Services Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodAndSvcsSubTp")]
    #endif
    [IsoXmlTag("GoodAndSvcsSubTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; init; } 
    #else
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Other goods and services sub type applied to the transaction.
    /// </summary>
    [IsoId("_GknVKyhKEeyhZIgCcGlTyA")]
    [DisplayName("Good And Services Other Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodAndSvcsOthrSubTp")]
    #endif
    [IsoXmlTag("GoodAndSvcsOthrSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GoodAndServicesOtherSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GoodAndServicesOtherSubType { get; init; } 
    #else
    public System.String? GoodAndServicesOtherSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Code that specifies the good or service delivery channel.
    /// </summary>
    [IsoId("_pHSlYD5LEeyHI64WSlzTlg")]
    [DisplayName("Good And Service Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodAndSvcDlvryChanl")]
    #endif
    [IsoXmlTag("GoodAndSvcDlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GoodAndServiceDeliveryChannel1Code? GoodAndServiceDeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GoodAndServiceDeliveryChannel1Code? GoodAndServiceDeliveryChannel { get; init; } 
    #else
    public GoodAndServiceDeliveryChannel1Code? GoodAndServiceDeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Other good or service delivery channel defined at private or national level.
    /// </summary>
    [IsoId("_3TryoD5LEeyHI64WSlzTlg")]
    [DisplayName("Other Good And Service Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrGoodAndSvcDlvryChanl")]
    #endif
    [IsoXmlTag("OthrGoodAndSvcDlvryChanl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherGoodAndServiceDeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherGoodAndServiceDeliveryChannel { get; init; } 
    #else
    public System.String? OtherGoodAndServiceDeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Code that specifies the good or service delivery schedule.
    /// </summary>
    [IsoId("_AJPeED5MEeyHI64WSlzTlg")]
    [DisplayName("Good And Service Delivery Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodAndSvcDlvrySchdl")]
    #endif
    [IsoXmlTag("GoodAndSvcDlvrySchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GoodAndServiceDeliverySchedule1Code? GoodAndServiceDeliverySchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GoodAndServiceDeliverySchedule1Code? GoodAndServiceDeliverySchedule { get; init; } 
    #else
    public GoodAndServiceDeliverySchedule1Code? GoodAndServiceDeliverySchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Other good or service delivery schedule defined at private or national level.
    /// </summary>
    [IsoId("_H9uuED5MEeyHI64WSlzTlg")]
    [DisplayName("Other Good And Service Delivery Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrGoodAndSvcDlvrySchdl")]
    #endif
    [IsoXmlTag("OthrGoodAndSvcDlvrySchdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherGoodAndServiceDeliverySchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherGoodAndServiceDeliverySchedule { get; init; } 
    #else
    public System.String? OtherGoodAndServiceDeliverySchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Also referred to as split tender. Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// True: Partial payment of a sale transaction
    /// False: Not a partial payment of a sale transaction.
    /// </summary>
    [IsoId("_GknVLShKEeyhZIgCcGlTyA")]
    [DisplayName("Split Payment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltPmtInd")]
    #endif
    [IsoXmlTag("SpltPmtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SplitPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SplitPaymentIndicator { get; init; } 
    #else
    public System.String? SplitPaymentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a receipt from the goods or services provider was requested.
    /// True: Receipt requested
    /// False: Receipt not requested.
    /// </summary>
    [IsoId("_GknVLyhKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Request Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctReqInd")]
    #endif
    [IsoXmlTag("RctReqInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReceiptRequestIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiptRequestIndicator { get; init; } 
    #else
    public System.String? ReceiptRequestIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of receipt requested or communication channel used.
    /// </summary>
    [IsoId("_GknVMShKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctTp")]
    #endif
    [IsoXmlTag("RctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceiptType1Code? ReceiptType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiptType1Code? ReceiptType { get; init; } 
    #else
    public ReceiptType1Code? ReceiptType { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the receipt (for example, e-mail address, SMS number, etc.).
    /// </summary>
    [IsoId("_GknVMyhKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctDstn")]
    #endif
    [IsoXmlTag("RctDstn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ReceiptDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiptDestination { get; init; } 
    #else
    public System.String? ReceiptDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_SeXxYShKEeyhZIgCcGlTyA")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
