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
/// Payment instrument for a type of order.
/// </summary>
[IsoId("_q3QsMF8rEeicg40_9gK9vQ")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstrument16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstrument16( FundOrderType5Choice_ reqOrderType,FundPaymentType1Choice_ reqInstrumentType )
    {
        OrderType = reqOrderType;
        InstrumentType = reqInstrumentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of order to which the payment instrument applies.
    /// </summary>
    [IsoId("_FhZzkF8sEeicg40_9gK9vQ")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundOrderType5Choice_ OrderType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundOrderType5Choice_ OrderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderType5Choice_ OrderType { get; init; } 
    #else
    public FundOrderType5Choice_ OrderType { get; set; } 
    #endif
    
    /// <summary>
    /// Payment instrument for the order type.
    /// </summary>
    [IsoId("_oIpUYF8sEeicg40_9gK9vQ")]
    [DisplayName("Instrument Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmTp")]
    #endif
    [IsoXmlTag("InstrmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundPaymentType1Choice_ InstrumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundPaymentType1Choice_ InstrumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundPaymentType1Choice_ InstrumentType { get; init; } 
    #else
    public FundPaymentType1Choice_ InstrumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the payment.
    /// </summary>
    [IsoId("_xXAigWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
