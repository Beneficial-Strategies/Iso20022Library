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
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_2cw6QQaUEe2-DuDrUXkg2w")]
[DisplayName("Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Report6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Report6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Report6( DateAndDateTime1Choice_ reqReportDateTime )
    {
        ReportDateTime = reqReportDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_2uWZgwaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the name and the reference of the query.
    /// </summary>
    [IsoId("_2uWZhQaUEe2-DuDrUXkg2w")]
    [DisplayName("Query Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRef")]
    #endif
    [IsoXmlTag("QryRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QueryReference2? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryReference2? QueryReference { get; init; } 
    #else
    public QueryReference2? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the report.
    /// </summary>
    [IsoId("_2uWZhwaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportIdentification { get; init; } 
    #else
    public System.String? ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_2uWZiQaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtTm")]
    #endif
    [IsoXmlTag("RptDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime1Choice_ ReportDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime1Choice_ ReportDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_ ReportDateTime { get; init; } 
    #else
    public DateAndDateTime1Choice_ ReportDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoId("_2uWZiwaUEe2-DuDrUXkg2w")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency25Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency25Choice_? Frequency { get; init; } 
    #else
    public Frequency25Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_2uWZjQaUEe2-DuDrUXkg2w")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementUpdateTypeCodeAndDSSCode1Choice_? UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementUpdateTypeCodeAndDSSCode1Choice_? UpdateType { get; init; } 
    #else
    public StatementUpdateTypeCodeAndDSSCode1Choice_? UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_2uWZjwaUEe2-DuDrUXkg2w")]
    [DisplayName("Notice Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtceTp")]
    #endif
    [IsoXmlTag("NtceTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? NoticeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? NoticeType { get; init; } 
    #else
    public GenericIdentification30? NoticeType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
