// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction4Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the original interbank payment transaction.
    /// </summary>
    [IsoId("_hbH5E4KZEee7hrXqLO3yQg")]
    [DisplayName("Interbank")]
    public record Interbank : UnderlyingTransaction4Choice_
    {
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_hjKaw4KZEee7hrXqLO3yQg")]
        [DisplayName("Original Group Information")]
        [IsoXmlTag("OrgnlGrpInf")]
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
        /// </summary>
        [IsoId("_hjKaxYKZEee7hrXqLO3yQg")]
        [DisplayName("Original Instruction Identification")]
        [IsoXmlTag("OrgnlInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? OriginalInstructionIdentification { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
        /// </summary>
        [IsoId("_hjKax4KZEee7hrXqLO3yQg")]
        [DisplayName("Original End To End Identification")]
        [IsoXmlTag("OrgnlEndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
        /// </summary>
        [IsoId("_hjKayYKZEee7hrXqLO3yQg")]
        [DisplayName("Original Transaction Identification")]
        [IsoXmlTag("OrgnlTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? OriginalTransactionIdentification { get; init; }

        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
        /// </summary>
        [IsoId("_hjKay4KZEee7hrXqLO3yQg")]
        [DisplayName("Original Interbank Settlement Amount")]
        [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
        public required ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; }

        /// <summary>
        /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_hjKazYKZEee7hrXqLO3yQg")]
        [DisplayName("Original Interbank Settlement Date")]
        [IsoXmlTag("OrgnlIntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate OriginalInterbankSettlementDate { get; init; }

        /// <summary>
        /// Key elements used to identify the original transaction that is being referred to.
        /// </summary>
        [IsoId("_ouIMoYKZEee7hrXqLO3yQg")]
        [DisplayName("Original Transaction Reference")]
        [IsoXmlTag("OrgnlTxRef")]
        public OriginalTransactionReference27? OriginalTransactionReference { get; init; }
    }
}
