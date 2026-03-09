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
/// Attributes of a settlement service.
/// </summary>
[IsoId("_b2XNYEX7Eeegp_DADCe7HQ")]
[DisplayName("Settlement Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementService1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of settlement service proposed.
    /// </summary>
    [IsoId("_57F3AEq2Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Proposed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvcPropsd")]
    #endif
    [IsoXmlTag("SttlmSvcPropsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementServiceMode1? SettlementServiceProposed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementServiceMode1? SettlementServiceProposed { get; init; } 
    #else
    public SettlementServiceMode1? SettlementServiceProposed { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    [IsoId("_COc0UEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvcApld")]
    #endif
    [IsoXmlTag("SttlmSvcApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementServiceMode1? SettlementServiceApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementServiceMode1? SettlementServiceApplied { get; init; } 
    #else
    public SettlementServiceMode1? SettlementServiceApplied { get; set; } 
    #endif
    
    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    [IsoId("_L6cYgEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvcDts")]
    #endif
    [IsoXmlTag("SttlmSvcDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementServiceDate1? SettlementServiceDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementServiceDate1? SettlementServiceDates { get; init; } 
    #else
    public SettlementServiceDate1? SettlementServiceDates { get; set; } 
    #endif
    
    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    [IsoId("_eG2ekEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmRptgNtty")]
    #endif
    [IsoXmlTag("SttlmRptgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; } 
    #else
    public SettlementReportingEntity1? SettlementReportingEntity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
