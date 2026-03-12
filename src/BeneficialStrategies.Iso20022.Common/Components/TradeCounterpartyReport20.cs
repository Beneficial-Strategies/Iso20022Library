// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to parties in the contract.
/// </summary>
[IsoId("_tqiloQz1Ee2YoLD-1vFj0g")]
[DisplayName("Trade Counterparty Report")]
public partial record TradeCounterpartyReport20
{
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty to a derivative transaction who is fulfilling its reporting obligation in the present report.
    /// </summary>
    [IsoId("_trQXUQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required Counterparty45 ReportingCounterparty { get; init; } 
    
    /// <summary>
    /// Identification of the other counterparty to a derivative transaction.
    /// </summary>
    [IsoId("_trQXUwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required Counterparty46 OtherCounterparty { get; init; } 
    
    /// <summary>
    /// Identification of the entity [party] acting as an intermediary which [who] arranges the transaction for the reporting counterparty (“arranging broker”).
    /// </summary>
    [IsoId("_trQXVQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    
    /// <summary>
    /// Identification of the party that ultimately submits the report to the trade repository.
    /// </summary>
    [IsoId("_trQXVwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public OrganisationIdentification15Choice_? SubmittingAgent { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_trQXWQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public PartyIdentification248Choice_? ClearingMember { get; init; } 
    
    /// <summary>
    /// Identification of the beneficiary of a derivative transaction, that is a party that is subject to the rights and obligations arising from the contract.
    /// ||Usage: In case of two occurances of beneficiary, the first iteration should always be the beneficiary 1 of the counterparty 1 and the second iteration is the beneficiary 2 of the counterparty 2. In case of single occurance of Beneficiary, RelationshipRecord should be provided.
    /// </summary>
    [IsoId("_trQXWwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<PartyIdentification248Choice_> Beneficiary { get; init; } = new ValueList<PartyIdentification248Choice_>(){};
    
    /// <summary>
    /// According to jurisdictional requirements, identification of the entity with the legal obligation or responsibility to report.
    /// </summary>
    [IsoId("_trQXXQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
    
    /// <summary>
    /// Identification of the entity that executed the transaction on behalf of the counterparty, and binds the counterparty to the terms of the transaction, but is not a broker.
    /// Usage: In case of two occurances of ExecutionAgent, the first iteration should always be the execution agent 1 of the counterparty 1 and the second iteration is the execution agent 2 of the counterparty 2. In case of single occurance of ExecutionAgent, RelationshipRecord should be provided.
    /// </summary>
    [IsoId("_U9tDoBZlEe27wrM4RUjLog")]
    [DisplayName("Execution Agent")]
    [IsoXmlTag("ExctnAgt")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<OrganisationIdentification15Choice_> ExecutionAgent { get; init; } = new ValueList<OrganisationIdentification15Choice_>(){};
    
    /// <summary>
    /// Specifies the relationship record between two parties part of the transaction.
    /// </summary>
    [IsoId("_NnAawCR6Ee2VuKUpJ7HXPg")]
    [DisplayName("Relationship Record")]
    [IsoXmlTag("RltshRcrd")]
    public TradeCounterpartyRelationshipRecord1? RelationshipRecord { get; init; } 
    
    
    #nullable disable
    
}
