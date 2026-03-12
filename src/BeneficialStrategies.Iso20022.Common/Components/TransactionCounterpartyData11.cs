// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details related to the parties involved in the securities lending transaction.
/// </summary>
[IsoId("_Z3Woocg4Eeu4ecZgAYuz5w")]
[DisplayName("Transaction Counterparty Data")]
public partial record TransactionCounterpartyData11
{
    #nullable enable
    
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_Z5G8I8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public PartyIdentification236Choice_? Beneficiary { get; init; } 
    
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_Z5G8Jcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    
    /// <summary>
    /// Identification of the broker involved in the securities lending transaction.
    /// </summary>
    [IsoId("_Z5G8J8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    
    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_Z5G8Kcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public OrganisationIdentification15Choice_? ClearingMember { get; init; } 
    
    /// <summary>
    /// Identification of the parties settling the contract on behalf of the deliverer or receiver.
    /// </summary>
    [IsoId("_Z5G8K8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties34Choice_? SettlementParties { get; init; } 
    
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_Z5G8Lcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    
    
    #nullable disable
    
}
