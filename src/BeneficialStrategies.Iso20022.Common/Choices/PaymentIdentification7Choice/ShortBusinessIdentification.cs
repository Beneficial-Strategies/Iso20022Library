// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification7Choice
{
    /// <summary>
    /// Business identification of the payment instruction given by the clearing agent.
    /// </summary>
    [IsoId("_5uqG9wKxEe2rHs6fbn9-0A")]
    [DisplayName("Short Business Identification")]
    public record ShortBusinessIdentification : PaymentIdentification7Choice_
    {
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
        /// </summary>
        [IsoId("_qJBZYQKyEe2X55dNQNVKfg")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TransactionIdentification { get; init; }

        /// <summary>
        /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_8wK6sAKyEe2X55dNQNVKfg")]
        [DisplayName("UETR")]
        [IsoXmlTag("UETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public IsoUUIDv4Identifier? UETR { get; init; }

        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_qJBZYwKyEe2X55dNQNVKfg")]
        [DisplayName("Interbank Settlement Date")]
        [IsoXmlTag("IntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate InterbankSettlementDate { get; init; }

        /// <summary>
        /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_qJBZZQKyEe2X55dNQNVKfg")]
        [DisplayName("Instructing Agent")]
        [IsoXmlTag("InstgAgt")]
        public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; }
    }
}
