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
/// Data specific to counterparties and related fields.
/// </summary>
[IsoId("_IKxnMc2HEeqFGLkKbAvCGg")]
[DisplayName("Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyData78
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyData78 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyData78( OrganisationIdentification10Choice_ reqReportSubmittingEntity,OrganisationIdentification10Choice_ reqReportingCounterparty )
    {
        ReportSubmittingEntity = reqReportSubmittingEntity;
        ReportingCounterparty = reqReportingCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_ILv3kc2HEeqFGLkKbAvCGg")]
    [DisplayName("Report Submitting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSubmitgNtty")]
    #endif
    [IsoXmlTag("RptSubmitgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification10Choice_ ReportSubmittingEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification10Choice_ ReportSubmittingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_ ReportSubmittingEntity { get; init; } 
    #else
    public OrganisationIdentification10Choice_ ReportSubmittingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_ILv3k82HEeqFGLkKbAvCGg")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification10Choice_ ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification10Choice_ ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_ ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification10Choice_ ReportingCounterparty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
