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
/// Defines the criteria used to search for system business day information.
/// </summary>
[IsoId("_yNYGiZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Business Day Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessDaySearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date for which the availability information is provided.
    /// </summary>
    [IsoId("_yVMlw5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysDt")]
    #endif
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SystemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SystemDate { get; init; } 
    #else
    public System.DateOnly? SystemDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the system, as assigned by the system administrator.
    /// </summary>
    [IsoId("_yVMlxZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #else
    public SystemIdentification2Choice_? SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_yVMlx5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysCcy")]
    #endif
    [IsoXmlTag("SysCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SystemCurrency { get; init; } 
    #else
    public string? SystemCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_yVMlyZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemEventType2Choice_? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventType2Choice_? EventType { get; init; } 
    #else
    public SystemEventType2Choice_? EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Period of time when the system is closed/not operating.
    /// </summary>
    [IsoId("_yVMly5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Closure Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrPrd")]
    #endif
    [IsoXmlTag("ClsrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ClosurePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ClosurePeriod { get; init; } 
    #else
    public DateTimePeriod1Choice_? ClosurePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
