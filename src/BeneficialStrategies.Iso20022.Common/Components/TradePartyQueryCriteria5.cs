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
[IsoId("_ahZU0a1TEemkQYpo6COeTA")]
[DisplayName("Trade Party Query Criteria")]
public partial record TradePartyQueryCriteria5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_alkDI61TEemkQYpo6COeTA")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; } 
    
    /// <summary>
    /// Identifies the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_alkDJa1TEemkQYpo6COeTA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Data specific to branch of the reporting counterparty and related fields.
    /// </summary>
    [IsoId("_alkDJ61TEemkQYpo6COeTA")]
    [DisplayName("Reporting Counterparty Branch")]
    [IsoXmlTag("RptgCtrPtyBrnch")]
    public TradePartyIdentificationQuery9? ReportingCounterpartyBranch { get; init; } 
    
    /// <summary>
    /// Identifies the other counterparty of the contract.
    /// </summary>
    [IsoId("_alkDKa1TEemkQYpo6COeTA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public TradePartyIdentificationQuery8? OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Data specific to branch of the other reporting counterparty and related fields.
    /// </summary>
    [IsoId("_alkDK61TEemkQYpo6COeTA")]
    [DisplayName("Other Counterparty Branch")]
    [IsoXmlTag("OthrCtrPtyBrnch")]
    public TradePartyIdentificationQuery9? OtherCounterpartyBranch { get; init; } 
    
    /// <summary>
    /// Identifies the party subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_alkDLa1TEemkQYpo6COeTA")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public TradePartyIdentificationQuery8? Beneficiary { get; init; } 
    
    /// <summary>
    /// Identifies the submitting agent of the reported of the contract.
    /// </summary>
    [IsoId("_alkDL61TEemkQYpo6COeTA")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public TradePartyIdentificationQuery8? SubmittingAgent { get; init; } 
    
    /// <summary>
    /// Identifies the broker who acts as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_alkDMa1TEemkQYpo6COeTA")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public TradePartyIdentificationQuery8? Broker { get; init; } 
    
    /// <summary>
    /// Unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_alkDM61TEemkQYpo6COeTA")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public TradePartyIdentificationQuery8? CCP { get; init; } 
    
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_NRqOsq60EemZxoEFHjN-AQ")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public TradePartyIdentificationQuery8? AgentLender { get; init; } 
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_NRqOs660EemZxoEFHjN-AQ")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public TradePartyIdentificationQuery8? TripartyAgent { get; init; } 
    
    
    #nullable disable
    
}
