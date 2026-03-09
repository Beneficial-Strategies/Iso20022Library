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
/// Parameters related to the net position.
/// </summary>
[IsoId("_Qk_hd9p-Ed-ak6NoX_4Aeg_937619716")]
[DisplayName("Report Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportParameters1( System.String reqNetPositionIdentification,DateAndDateTimeChoice_ reqReportDateAndTime,StatementUpdateType1Code reqUpdateType,EventFrequency6Code reqFrequency,System.String reqActivityIndicator )
    {
        NetPositionIdentification = reqNetPositionIdentification;
        ReportDateAndTime = reqReportDateAndTime;
        UpdateType = reqUpdateType;
        Frequency = reqFrequency;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// After netting, reference that is common to a net transaction to settle and all its underlying trades.
    /// </summary>
    [IsoId("_Qk_heNp-Ed-ak6NoX_4Aeg_-1693107427")]
    [DisplayName("Net Position Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPosId")]
    #endif
    [IsoXmlTag("NetPosId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text NetPositionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NetPositionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NetPositionIdentification { get; init; } 
    #else
    public System.String NetPositionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the net position report.
    /// </summary>
    [IsoId("_QlIrYNp-Ed-ak6NoX_4Aeg_1816598291")]
    [DisplayName("Report Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtAndTm")]
    #endif
    [IsoXmlTag("RptDtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ ReportDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QlIrYdp-Ed-ak6NoX_4Aeg_-853608276")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementUpdateType1Code UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementUpdateType1Code UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementUpdateType1Code UpdateType { get; init; } 
    #else
    public StatementUpdateType1Code UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_QlIrYtp-Ed-ak6NoX_4Aeg_414984299")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventFrequency6Code Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventFrequency6Code Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency6Code Frequency { get; init; } 
    #else
    public EventFrequency6Code Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QlIrY9p-Ed-ak6NoX_4Aeg_-378663272")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QlIrZNp-Ed-ak6NoX_4Aeg_-704566571")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
