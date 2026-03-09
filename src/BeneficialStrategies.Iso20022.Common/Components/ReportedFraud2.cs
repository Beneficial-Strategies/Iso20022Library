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
/// Fraud reporting type information
/// </summary>
[IsoId("_Nfi6oZjCEeefZKJHxQTztg")]
[DisplayName("Reported Fraud")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportedFraud2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportedFraud2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportedFraud2( FraudType1Code reqFraudType,FraudReportingAction1Code reqFraudReportingAction,PartyType25Code reqReportingEntity )
    {
        FraudType = reqFraudType;
        FraudReportingAction = reqFraudReportingAction;
        ReportingEntity = reqReportingEntity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of fraud for which a report is established.
    /// </summary>
    [IsoId("_NtFnYZjCEeefZKJHxQTztg")]
    [DisplayName("Fraud Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdTp")]
    #endif
    [IsoXmlTag("FrdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudType1Code FraudType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudType1Code FraudType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudType1Code FraudType { get; init; } 
    #else
    public FraudType1Code FraudType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of fraud.
    /// </summary>
    [IsoId("_NtFnY5jCEeefZKJHxQTztg")]
    [DisplayName("Other Fraud Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrdTp")]
    #endif
    [IsoXmlTag("OthrFrdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFraudType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFraudType { get; init; } 
    #else
    public System.String? OtherFraudType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of reported fraudulent transaction.
    /// </summary>
    [IsoId("_NtFnZZjCEeefZKJHxQTztg")]
    [DisplayName("Fraud Reporting Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdRptgActn")]
    #endif
    [IsoXmlTag("FrdRptgActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudReportingAction1Code FraudReportingAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudReportingAction1Code FraudReportingAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudReportingAction1Code FraudReportingAction { get; init; } 
    #else
    public FraudReportingAction1Code FraudReportingAction { get; set; } 
    #endif
    
    /// <summary>
    /// Other fraud reporting action.
    /// </summary>
    [IsoId("_NtFnZ5jCEeefZKJHxQTztg")]
    [DisplayName("Other Fraud Reporting Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrdRptgActn")]
    #endif
    [IsoXmlTag("OthrFrdRptgActn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFraudReportingAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFraudReportingAction { get; init; } 
    #else
    public System.String? OtherFraudReportingAction { get; set; } 
    #endif
    
    /// <summary>
    /// Type of fraud reporting entity.
    /// </summary>
    [IsoId("_NtFnaZjCEeefZKJHxQTztg")]
    [DisplayName("Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgNtty")]
    #endif
    [IsoXmlTag("RptgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType25Code ReportingEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType25Code ReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType25Code ReportingEntity { get; init; } 
    #else
    public PartyType25Code ReportingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of fraud reporting entity.
    /// </summary>
    [IsoId("_NtFna5jCEeefZKJHxQTztg")]
    [DisplayName("Other Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRptgNtty")]
    #endif
    [IsoXmlTag("OthrRptgNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherReportingEntity { get; init; } 
    #else
    public System.String? OtherReportingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the case as provided by the submitter.
    /// </summary>
    [IsoId("_NtFnc5jCEeefZKJHxQTztg")]
    [DisplayName("Submitter Case Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrCaseRef")]
    #endif
    [IsoXmlTag("SubmitrCaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubmitterCaseReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubmitterCaseReference { get; init; } 
    #else
    public System.String? SubmitterCaseReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to fraudulent case.
    /// </summary>
    [IsoId("_NtFneZjCEeefZKJHxQTztg")]
    [DisplayName("Case Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CaseRef")]
    #endif
    [IsoXmlTag("CaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CaseReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CaseReference { get; init; } 
    #else
    public System.String? CaseReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
