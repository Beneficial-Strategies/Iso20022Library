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
/// Telecom services line item carries detail level telephony billing data. 
/// </summary>
[IsoId("_BPv8AR1DEey8XKHwKquEQw")]
[DisplayName("Telecom Services Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TelecomServicesLineItem2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the start date and time of the phone call.
    /// </summary>
    [IsoId("_BVmFUR1DEey8XKHwKquEQw")]
    [DisplayName("Start Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDtTm")]
    #endif
    [IsoXmlTag("StartDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDateTime { get; init; } 
    #else
    public System.DateOnly? StartDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the period (such as peak or off peak) of the phone call.
    /// </summary>
    [IsoId("_BVmFUx1DEey8XKHwKquEQw")]
    [DisplayName("Time Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmPrd")]
    #endif
    [IsoXmlTag("TmPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TimePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimePeriod { get; init; } 
    #else
    public System.String? TimePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of phone call expressed in HHMMSS format. 
    /// </summary>
    [IsoId("_BVmFVR1DEey8XKHwKquEQw")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Duration { get; init; } 
    #else
    public System.TimeOnly? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the location description for the originator of the telephone call and the number from which the call was made.
    /// </summary>
    [IsoId("_BVmFVx1DEey8XKHwKquEQw")]
    [DisplayName("Call From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallFr")]
    #endif
    [IsoXmlTag("CallFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomCallDetails2? CallFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomCallDetails2? CallFrom { get; init; } 
    #else
    public TelecomCallDetails2? CallFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the location description for the destination of the telephone call and the number to which the call was made.
    /// </summary>
    [IsoId("_BVmFWR1DEey8XKHwKquEQw")]
    [DisplayName("Call To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallTo")]
    #endif
    [IsoXmlTag("CallTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomCallDetails2? CallTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomCallDetails2? CallTo { get; init; } 
    #else
    public TelecomCallDetails2? CallTo { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the amount pertaining to the telephony billing event.
    /// </summary>
    [IsoId("_BVmFWx1DEey8XKHwKquEQw")]
    [DisplayName("Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrg")]
    #endif
    [IsoXmlTag("Chrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount20? Charge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount20? Charge { get; init; } 
    #else
    public Amount20? Charge { get; set; } 
    #endif
    
    /// <summary>
    /// Total of taxes applicable to the billing amount
    /// </summary>
    [IsoId("_BVmFXR1DEey8XKHwKquEQw")]
    [DisplayName("Total Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTax")]
    #endif
    [IsoXmlTag("TtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? TotalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? TotalTax { get; init; } 
    #else
    public Tax39? TotalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount applicable to the billing event. 
    /// </summary>
    [IsoId("_BVmFXx1DEey8XKHwKquEQw")]
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
    /// Description of the telecommunications services line item details
    /// </summary>
    [IsoId("_BVmFYR1DEey8XKHwKquEQw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the telecommunications services.
    /// </summary>
    [IsoId("_BVmFYx1DEey8XKHwKquEQw")]
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
