// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice
{
    /// <summary>
    /// Indicates an update to the valuations of a previously reported position, but not a correction.
    /// </summary>
    [IsoId("_zvSsf8g3EeuGrNSsxk3B0A")]
    [DisplayName("Valuation Update")]
    [IsoXmlTag("ValtnUpd")]
    public record ValuationUpdate : TradeReport22Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_HL-CMc0HEeufhKfUxzsnrQ")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_HL-CM80HEeufhKfUxzsnrQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        public required CounterpartyData88 CounterpartySpecificData { get; init; }

        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_HL-CNc0HEeufhKfUxzsnrQ")]
        [DisplayName("Loan Data")]
        [IsoXmlTag("LnData")]
        public required LoanData113 LoanData { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_HL-CN80HEeufhKfUxzsnrQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
