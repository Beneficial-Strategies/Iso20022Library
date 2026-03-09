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
[IsoId("_JbLJ45rhEeOu4p9bQU8tNA")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement37 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement37( System.String reqStatementIdentification,DateAndDateTimeChoice_ reqStatementDateTime,DatePeriod1Choice_ reqStatementPeriod,System.String reqActivityIndicator )
    {
        StatementIdentification = reqStatementIdentification;
        StatementDateTime = reqStatementDateTime;
        StatementPeriod = reqStatementPeriod;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_JbLw0JrhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtNb")]
    #endif
    [IsoXmlTag("StmtNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number3Choice_? StatementNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number3Choice_? StatementNumber { get; init; } 
    #else
    public Number3Choice_? StatementNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_JbMX4JrhEeOu4p9bQU8tNA")]
    [DisplayName("Query Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRef")]
    #endif
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryReference { get; init; } 
    #else
    public System.String? QueryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to all pages of the statement.
    /// </summary>
    [IsoId("_JbLJ5JrhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the statement was created.
    /// </summary>
    [IsoId("_JbLJ6prhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date period for which the statement was created.
    /// </summary>
    [IsoId("_NKm64J79EeOieb-y7x0pFg")]
    [DisplayName("Statement Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtPrd")]
    #endif
    [IsoXmlTag("StmtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriod1Choice_ StatementPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriod1Choice_ StatementPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1Choice_ StatementPeriod { get; init; } 
    #else
    public DatePeriod1Choice_ StatementPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_JbLw2JrhEeOu4p9bQU8tNA")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency22Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency22Choice_? Frequency { get; init; } 
    #else
    public Frequency22Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Granularity of the frequency used for the reporting.
    /// </summary>
    [IsoId("_LwypIDy6EeS4E7Ac8_OV3g")]
    [DisplayName("Frequency Granularity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrqcyGrnlrty")]
    #endif
    [IsoXmlTag("FrqcyGrnlrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FrequencyGranularityType1Code? FrequencyGranularity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FrequencyGranularityType1Code? FrequencyGranularity { get; init; } 
    #else
    public FrequencyGranularityType1Code? FrequencyGranularity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_JbLw3JrhEeOu4p9bQU8tNA")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdateType4Choice_? UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType4Choice_? UpdateType { get; init; } 
    #else
    public UpdateType4Choice_? UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or updated information reported in the statement.
    /// </summary>
    [IsoId("_JbLJ5prhEeOu4p9bQU8tNA")]
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
