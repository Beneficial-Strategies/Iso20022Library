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
/// Set of information specific to the counterparty.
/// </summary>
[IsoId("_4KmaIcg3EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyData89
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyData89 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyData89( CounterpartyIdentification11 reqReportingCounterparty,CounterpartyIdentification12 reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of information identifying the reporting counterparty.
    /// </summary>
    [IsoId("_4MnMUcg3EeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyIdentification11 ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyIdentification11 ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyIdentification11 ReportingCounterparty { get; init; } 
    #else
    public CounterpartyIdentification11 ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_4MnMU8g3EeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyIdentification12 OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyIdentification12 OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyIdentification12 OtherCounterparty { get; init; } 
    #else
    public CounterpartyIdentification12 OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// In the case where a financial counterparty is responsible for reporting on behalf of the other counterparty, the unique code identifying that counterparty. In the case where a management company is responsible for reporting on behalf of an Undertaking for Collective Investment in Transferable Securities (UCITS), the unique code identifying that management company. In the case where an Alternative Investment Fund Manager (AIFM) is responsible for reporting on behalf of an Alternative Investment Fund (AIF), the unique code identifying that AIFM.
    /// </summary>
    [IsoId("_4MnMVcg3EeuGrNSsxk3B0A")]
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
    /// Information on the other parties.
    /// </summary>
    [IsoId("_4MnMV8g3EeuGrNSsxk3B0A")]
    [DisplayName("Other Party Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPtyData")]
    #endif
    [IsoXmlTag("OthrPtyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionCounterpartyData11? OtherPartyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCounterpartyData11? OtherPartyData { get; init; } 
    #else
    public TransactionCounterpartyData11? OtherPartyData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
