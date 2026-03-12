// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the queried trade parties.
/// </summary>
[IsoId("_v8mgsZNYEeytjZlcgApf6A")]
[DisplayName("Trade Party Query Criteria")]
public partial record TradePartyQueryCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_v-O4Y5NYEeytjZlcgApf6A")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; } 
    
    /// <summary>
    /// Identifies the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_v-O4ZZNYEeytjZlcgApf6A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Identifies the other counterparty of the contract.
    /// </summary>
    [IsoId("_v-O4Z5NYEeytjZlcgApf6A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public TradePartyIdentificationQuery8? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Identifies the party subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_v-O4aZNYEeytjZlcgApf6A")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public TradePartyIdentificationQuery8? Beneficiary { get; init; } 
    
    /// <summary>
    /// Identification of the entity in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_4b3MAJNYEeytjZlcgApf6A")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public TradePartyIdentificationQuery8? EntityResponsibleForReport { get; init; } 
    
    /// <summary>
    /// Identifies the submitting agent of the reported of the contract.
    /// </summary>
    [IsoId("_v-O4a5NYEeytjZlcgApf6A")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public TradePartyIdentificationQuery8? SubmittingAgent { get; init; } 
    
    /// <summary>
    /// Identifies the broker who acts as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_v-O4bZNYEeytjZlcgApf6A")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public TradePartyIdentificationQuery8? Broker { get; init; } 
    
    /// <summary>
    /// Unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_v-O4b5NYEeytjZlcgApf6A")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public TradePartyIdentificationQuery8? CCP { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_Uv_I8JNZEeytjZlcgApf6A")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public TradePartyIdentificationQuery8? ClearingMember { get; init; } 
    
    
    #nullable disable
    
}
