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
    [IsoId("_5uqG9QKxEe2rHs6fbn9-0A")]
    [DisplayName("Long Business Identification")]
    public record LongBusinessIdentification : PaymentIdentification7Choice_
    {
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
        /// </summary>
        [IsoId("_6Zt2IwKxEe2rHs6fbn9-0A")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TransactionIdentification { get; init; }

        /// <summary>
        /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_6Zt2JQKxEe2rHs6fbn9-0A")]
        [DisplayName("UETR")]
        [IsoXmlTag("UETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public IsoUUIDv4Identifier? UETR { get; init; }

        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent.
        /// </summary>
        [IsoId("_6Zt2JwKxEe2rHs6fbn9-0A")]
        [DisplayName("Interbank Settlement Amount")]
        [IsoXmlTag("IntrBkSttlmAmt")]
        public required ImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; }

        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_6Zt2KQKxEe2rHs6fbn9-0A")]
        [DisplayName("Interbank Settlement Date")]
        [IsoXmlTag("IntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate InterbankSettlementDate { get; init; }

        /// <summary>
        /// Message type with which the instruction has been initiated.
        /// </summary>
        [IsoId("_6Zt2KwKxEe2rHs6fbn9-0A")]
        [DisplayName("Payment Method")]
        [IsoXmlTag("PmtMtd")]
        public PaymentOrigin1Choice_? PaymentMethod { get; init; }

        /// <summary>
        /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_6Zt2LQKxEe2rHs6fbn9-0A")]
        [DisplayName("Instructing Agent")]
        [IsoXmlTag("InstgAgt")]
        public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; }

        /// <summary>
        /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_6Zt2LwKxEe2rHs6fbn9-0A")]
        [DisplayName("Instructed Agent")]
        [IsoXmlTag("InstdAgt")]
        public required BranchAndFinancialInstitutionIdentification6 InstructedAgent { get; init; }

        /// <summary>
        /// Optional qualifier providing additional system specific information about the entry.
        /// </summary>
        [IsoId("_6Zt2MQKxEe2rHs6fbn9-0A")]
        [DisplayName("Entry Type")]
        [IsoXmlTag("NtryTp")]
        [IsoSimpleType(IsoSimpleType.EntryTypeIdentifier)]
        public IsoEntryTypeIdentifier? EntryType { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
        /// </summary>
        [IsoId("_6Zt2MwKxEe2rHs6fbn9-0A")]
        [DisplayName("End To End Identification")]
        [IsoXmlTag("EndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? EndToEndIdentification { get; init; }
    }
}
