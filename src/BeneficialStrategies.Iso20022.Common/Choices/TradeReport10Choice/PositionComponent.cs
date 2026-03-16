// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice
{
    /// <summary>
    /// Indicates contract that is to be reported as a new trade and also included in a separate position report on the same day.
    /// </summary>
    [IsoId("_38nfWf_qEemm3skPVSMJQg")]
    [DisplayName("Position Component")]
    public record PositionComponent : TradeReport10Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_4AyNof_qEemm3skPVSMJQg")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_4AyNo__qEemm3skPVSMJQg")]
        [DisplayName("Counterparty Data")]
        [IsoXmlTag("CtrPtyData")]
        public required CounterpartyData76 CounterpartyData { get; init; }

        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_4AyNpf_qEemm3skPVSMJQg")]
        [DisplayName("Loan Data")]
        [IsoXmlTag("LnData")]
        public TransactionLoanData21Choice_? LoanData { get; init; }

        /// <summary>
        /// Information on collateral used in the transaction.
        /// </summary>
        [IsoId("_4AyNp__qEemm3skPVSMJQg")]
        [DisplayName("Collateral Data")]
        [IsoXmlTag("CollData")]
        public CollateralData27? CollateralData { get; init; }

        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_4AyNqf_qEemm3skPVSMJQg")]
        [DisplayName("Level Type")]
        [IsoXmlTag("LvlTp")]
        public required ModificationLevel1Code LevelType { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_4AyNq__qEemm3skPVSMJQg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
