// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details related to the parties involved in the securities lending transaction.
/// </summary>
[IsoId("_whK7GbQzEemI67HK7aviyg")]
[DisplayName("Transaction Counterparty Data")]
public record TransactionCounterpartyData8
{
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_wlpLYbQzEemI67HK7aviyg")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public OrganisationIdentification9Choice_? Beneficiary { get; init; }

    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_wlpLY7QzEemI67HK7aviyg")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public OrganisationIdentification9Choice_? TripartyAgent { get; init; }

    /// <summary>
    /// Identification of the broker involved in the securities lending transaction.
    /// </summary>
    [IsoId("_wlpLZbQzEemI67HK7aviyg")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public OrganisationIdentification9Choice_? Broker { get; init; }

    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_wlpLZ7QzEemI67HK7aviyg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public OrganisationIdentification9Choice_? ClearingMember { get; init; }

    /// <summary>
    /// Identification of the parties settling the contract on behalf of the deliverer or receiver.
    /// </summary>
    [IsoId("_wlpLabQzEemI67HK7aviyg")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties32Choice_? SettlementParties { get; init; }

    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_wlpLa7QzEemI67HK7aviyg")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public OrganisationIdentification9Choice_? AgentLender { get; init; }
}
