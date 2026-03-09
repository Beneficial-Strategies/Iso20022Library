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
/// Set of information specific to the counterparties of the reported transaction.
/// </summary>
[IsoId("_5CDkdcgoEeuGrNSsxk3B0A")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Counterparty39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Counterparty39( OrganisationIdentification15Choice_ reqReportingCounterparty,PartyIdentification236Choice_ reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_5DZoMcgoEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_ ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_5DZoM8goEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_ OtherCounterparty { get; init; } 
    #else
    public PartyIdentification236Choice_ OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_5DZoNcgoEeuGrNSsxk3B0A")]
    [DisplayName("Entity Responsible For Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NttyRspnsblForRpt")]
    #endif
    [IsoXmlTag("NttyRspnsblForRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    #else
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_5DZoN8goEeuGrNSsxk3B0A")]
    [DisplayName("Report Submitting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSubmitgNtty")]
    #endif
    [IsoXmlTag("RptSubmitgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? ReportSubmittingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? ReportSubmittingEntity { get; init; } 
    #else
    public OrganisationIdentification15Choice_? ReportSubmittingEntity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
