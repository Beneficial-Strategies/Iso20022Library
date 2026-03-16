// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport10Choice
{
    /// <summary>
    /// Indicates whether transaction was reported by mistake and needs to be removed.
    /// </summary>
    [IsoId("_38nfVf_qEemm3skPVSMJQg")]
    [DisplayName("Error")]
    public record Error : TradeReport10Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_pk_IUaxtEem81-uIvTF5rQ")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_pk_IU6xtEem81-uIvTF5rQ")]
        [DisplayName("Counterparty Data")]
        [IsoXmlTag("CtrPtyData")]
        public required CounterpartyData60 CounterpartyData { get; init; }

        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_Bt9CcK0pEemlgIolf65eZg")]
        [DisplayName("Loan Data")]
        [IsoXmlTag("LnData")]
        public required LoanData86 LoanData { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_pk_IW6xtEem81-uIvTF5rQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
