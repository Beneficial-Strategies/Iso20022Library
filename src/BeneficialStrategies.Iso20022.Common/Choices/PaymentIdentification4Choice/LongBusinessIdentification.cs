// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification4Choice
{
    /// <summary>
    /// Business identification of the payment instruction given by the clearing agent.
    /// </summary>
    [IsoId("_74w4oqMgEeCJ6YNENx4h-w_-1853582681")]
    [DisplayName("Long Business Identification")]
    public partial record LongBusinessIdentification : PaymentIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
        /// </summary>
        [IsoId("_8DWYAKMgEeCJ6YNENx4h-w_532692996")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text TransactionIdentification { get; init; } 
        
        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent.
        /// </summary>
        [IsoId("_8DWYAaMgEeCJ6YNENx4h-w_1972753841")]
        [DisplayName("Inter Bank Settlement Amount")]
        [IsoXmlTag("IntrBkSttlmAmt")]
        public required ImpliedCurrencyAndAmount InterBankSettlementAmount { get; init; } 
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_8DWYAqMgEeCJ6YNENx4h-w_-964402499")]
        [DisplayName("Inter Bank Settlement Date")]
        [IsoXmlTag("IntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate InterBankSettlementDate { get; init; } 
        
        /// <summary>
        /// Message type with which the instruction has been initiated.
        /// </summary>
        [IsoId("_8DWYA6MgEeCJ6YNENx4h-w_1486695808")]
        [DisplayName("Payment Method")]
        [IsoXmlTag("PmtMtd")]
        public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
        
        /// <summary>
        /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_8DWYBKMgEeCJ6YNENx4h-w_1956772218")]
        [DisplayName("Instructing Agent")]
        [IsoXmlTag("InstgAgt")]
        public required BranchAndFinancialInstitutionIdentification5 InstructingAgent { get; init; } 
        
        /// <summary>
        /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
        /// </summary>
        [IsoId("_8DWYBaMgEeCJ6YNENx4h-w_2087781912")]
        [DisplayName("Instructed Agent")]
        [IsoXmlTag("InstdAgt")]
        public required BranchAndFinancialInstitutionIdentification5 InstructedAgent { get; init; } 
        
        /// <summary>
        /// Optional qualifier providing additional system specific information about the entry.
        /// </summary>
        [IsoId("_8DWYBqMgEeCJ6YNENx4h-w_890975572")]
        [DisplayName("Entry Type")]
        [IsoXmlTag("NtryTp")]
        [IsoSimpleType(IsoSimpleType.EntryTypeIdentifier)]
        public IsoEntryTypeIdentifier? EntryType { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
        /// </summary>
        [IsoId("_8DWYB6MgEeCJ6YNENx4h-w_1361051982")]
        [DisplayName("End To End Identification")]
        [IsoXmlTag("EndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? EndToEndIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
