// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information specific to the counterparty.
/// </summary>
[IsoId("_4KmaIcg3EeuGrNSsxk3B0A")]
[DisplayName("Counterparty Data")]
public partial record CounterpartyData89
{
    #nullable enable
    
    /// <summary>
    /// Set of information identifying the reporting counterparty.
    /// </summary>
    [IsoId("_4MnMUcg3EeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required CounterpartyIdentification11 ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_4MnMU8g3EeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required CounterpartyIdentification12 OtherCounterparty { get; init; } 
    
    /// <summary>
    /// In the case where a financial counterparty is responsible for reporting on behalf of the other counterparty, the unique code identifying that counterparty. In the case where a management company is responsible for reporting on behalf of an Undertaking for Collective Investment in Transferable Securities (UCITS), the unique code identifying that management company. In the case where an Alternative Investment Fund Manager (AIFM) is responsible for reporting on behalf of an Alternative Investment Fund (AIF), the unique code identifying that AIFM.
    /// </summary>
    [IsoId("_4MnMVcg3EeuGrNSsxk3B0A")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    
    /// <summary>
    /// Information on the other parties.
    /// </summary>
    [IsoId("_4MnMV8g3EeuGrNSsxk3B0A")]
    [DisplayName("Other Party Data")]
    [IsoXmlTag("OthrPtyData")]
    public TransactionCounterpartyData11? OtherPartyData { get; init; } 
    
    
    #nullable disable
    
}
