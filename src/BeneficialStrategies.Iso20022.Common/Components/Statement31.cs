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
/// Provides statement details such as the account owner identification (ie, the clearing member identification) and optionaly the non clearing member identification, the clearing account or the list of trade legs.
/// </summary>
[IsoId("_QllXWNp-Ed-ak6NoX_4Aeg_530575505")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement31( System.String reqStatementIdentification,DateAndDateTimeChoice_ reqStatementDateAndTime,StatementUpdateType1Code reqUpdateType,EventFrequency6Code reqFrequency,System.String reqActivityIndicator )
    {
        StatementIdentification = reqStatementIdentification;
        StatementDateAndTime = reqStatementDateAndTime;
        UpdateType = reqUpdateType;
        Frequency = reqFrequency;
        ActivityIndicator = reqActivityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification that is common to all pages of a statement.
    /// </summary>
    [IsoId("_QlvIUNp-Ed-ak6NoX_4Aeg_-743464227")]
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
    /// Date of the statement.
    /// </summary>
    [IsoId("_QlvIUdp-Ed-ak6NoX_4Aeg_1952721885")]
    [DisplayName("Statement Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtAndTm")]
    #endif
    [IsoXmlTag("StmtDtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ StatementDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateAndTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QlvIUtp-Ed-ak6NoX_4Aeg_-1456594796")]
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
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QlvIU9p-Ed-ak6NoX_4Aeg_1407832177")]
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
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_QlvIVNp-Ed-ak6NoX_4Aeg_2070796472")]
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
    [IsoId("_QlvIVdp-Ed-ak6NoX_4Aeg_929830275")]
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
