// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparty.
/// </summary>
[IsoId("_4j8ct7HYEemRPNDOvJwndA")]
[DisplayName("Counterparty Data")]
public partial record CounterpartyData77
{
    #nullable enable
    
    /// <summary>
    /// Information describing the reporting counterparty.
    /// </summary>
    [IsoId("_4nrGIbHYEemRPNDOvJwndA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required CounterpartyIdentification4 ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Data specific to other counterparties and related fields.
    /// </summary>
    [IsoId("_4nrGI7HYEemRPNDOvJwndA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required CounterpartyIdentification2 OtherCounterparty { get; init; } 
    
    /// <summary>
    /// In the case where a financial counterparty is responsible for reporting on behalf of the other counterparty, the unique code identifying that counterparty. In the case where a management company is responsible for reporting on behalf of an Undertaking for Collective Investment in Transferable Securities (UCITS), the unique code identifying that management company. In the case where an Alternative Investment Fund Manager (AIFM) is responsible for reporting on behalf of an Alternative Investment Fund (AIF), the unique code identifying that AIFM.
    /// </summary>
    [IsoId("_4nrGJbHYEemRPNDOvJwndA")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification9Choice_? EntityResponsibleForReport { get; init; } 
    
    /// <summary>
    /// Information on the other parties.
    /// </summary>
    [IsoId("_4nrGJ7HYEemRPNDOvJwndA")]
    [DisplayName("Other Party Data")]
    [IsoXmlTag("OthrPtyData")]
    public TransactionCounterpartyData8? OtherPartyData { get; init; } 
    
    
    #nullable disable
    
}
