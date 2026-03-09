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
/// Lodging line item details
/// </summary>
[IsoId("_sR3mqvcZEeiW-auGnDPZIw")]
[DisplayName("Lodging Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LodgingLineItem1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3mq_cZEeiW-auGnDPZIw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Time of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3msPcZEeiW-auGnDPZIw")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Time { get; init; } 
    #else
    public System.TimeOnly? Time { get; set; } 
    #endif
    
    /// <summary>
    /// Type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3muvcZEeiW-auGnDPZIw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingService1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingService1Code? Type { get; init; } 
    #else
    public LodgingService1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3mt_cZEeiW-auGnDPZIw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the charge originated following the checkout. 
    /// </summary>
    [IsoId("_sR3msvcZEeiW-auGnDPZIw")]
    [DisplayName("Post Check Out Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstChckOutInd")]
    #endif
    [IsoXmlTag("PstChckOutInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PostCheckOutIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostCheckOutIndicator { get; init; } 
    #else
    public System.String? PostCheckOutIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    [IsoId("_sR3mwPcZEeiW-auGnDPZIw")]
    [DisplayName("Credit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInd")]
    #endif
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditIndicator { get; init; } 
    #else
    public System.String? CreditIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the cost for one unit of the product or service.
    /// </summary>
    [IsoId("_sR3mw_cZEeiW-auGnDPZIw")]
    [DisplayName("Unit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitAmt")]
    #endif
    [IsoXmlTag("UnitAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_GDYK4fccEeiW-auGnDPZIw")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Duration { get; init; } 
    #else
    public System.String? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Subtotal amount of line item.  (e.g. total nightly rate, etc.)
    /// </summary>
    [IsoId("_sR3mv_cZEeiW-auGnDPZIw")]
    [DisplayName("Sub Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTtlAmt")]
    #endif
    [IsoXmlTag("SubTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_sR3mtPcZEeiW-auGnDPZIw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? Tax { get; init; } 
    #else
    public Tax33? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Additional data.
    /// </summary>
    [IsoId("_sR3mtvcZEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
