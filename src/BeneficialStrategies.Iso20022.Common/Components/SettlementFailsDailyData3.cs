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
/// Specifies the details for a specific date on the daily data on settlement fails instructions.
/// </summary>
[IsoId("_XevB0TOqEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsDailyData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsDailyData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsDailyData3( System.DateOnly reqReportingDate,SettlementFailsDailyInstrument3 reqDailyRecord )
    {
        ReportingDate = reqReportingDate;
        DailyRecord = reqDailyRecord;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date for each reporting day in the month.
    /// </summary>
    [IsoId("_XfxjoTOqEeqX8uoQQ3KffQ")]
    [DisplayName("Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDt")]
    #endif
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReportingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReportingDate { get; init; } 
    #else
    public System.DateOnly ReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the failed settlement instructions for the reporting date.
    /// </summary>
    [IsoId("_XfxjozOqEeqX8uoQQ3KffQ")]
    [DisplayName("Daily Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DalyRcrd")]
    #endif
    [IsoXmlTag("DalyRcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyInstrument3 DailyRecord { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyInstrument3 DailyRecord { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyInstrument3 DailyRecord { get; init; } 
    #else
    public SettlementFailsDailyInstrument3 DailyRecord { get; set; } 
    #endif
    
    
    #nullable disable
    
}
