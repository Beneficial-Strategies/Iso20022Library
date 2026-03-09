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
/// Date related to the settlement of the transaction.
/// </summary>
[IsoId("_eG_WwEX8Eeegp_DADCe7HQ")]
[DisplayName("Settlement Service Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementServiceDate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date requested for settlement.
    /// </summary>
    [IsoId("_08wNkEX8Eeegp_DADCe7HQ")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual date of settlement.
    /// ISO 8583 bit 15.
    /// </summary>
    [IsoId("_5uzAQEX8Eeegp_DADCe7HQ")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual time of settlement.
    /// </summary>
    [IsoId("_OYpPomp-EemXfKijhrqa-Q")]
    [DisplayName("Settlement Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTm")]
    #endif
    [IsoXmlTag("SttlmTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? SettlementTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? SettlementTime { get; init; } 
    #else
    public System.TimeOnly? SettlementTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the settlement period, cycle or group. May contain settlement frequency or the identification of specific settlement period. For example, daily, monthly or settlementperiod123acd.
    /// </summary>
    [IsoId("_BFdF0Gp_EemXfKijhrqa-Q")]
    [DisplayName("Settlement Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrd")]
    #endif
    [IsoXmlTag("SttlmPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SettlementPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementPeriod { get; init; } 
    #else
    public System.String? SettlementPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the effective end time of the settlement date and/or period. 
    /// </summary>
    [IsoId("_OYpPo2p-EemXfKijhrqa-Q")]
    [DisplayName("Settlement Cut Off Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCutOffTm")]
    #endif
    [IsoXmlTag("SttlmCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SettlementCutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SettlementCutOffTime { get; init; } 
    #else
    public System.DateTime? SettlementCutOffTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
