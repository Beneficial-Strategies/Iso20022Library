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
[IsoId("_x_vqwUk2EeyrgKBCkF1_RQ")]
[DisplayName("Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyData91
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reporting counterparty.
    /// </summary>
    [IsoId("_yCGbMUk2EeyrgKBCkF1_RQ")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the other counterparty in the transaction.
    /// </summary>
    [IsoId("_yCGbM0k2EeyrgKBCkF1_RQ")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification236Choice_? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification236Choice_? OtherCounterparty { get; init; } 
    #else
    public PartyIdentification236Choice_? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_6zPgsEk2EeyrgKBCkF1_RQ")]
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
    
    /// <summary>
    /// Unique code identifying that counterparty in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("__qFT0Ek2EeyrgKBCkF1_RQ")]
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
    
    
    #nullable disable
    
}
