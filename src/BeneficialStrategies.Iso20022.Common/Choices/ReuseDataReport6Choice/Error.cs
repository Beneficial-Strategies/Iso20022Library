// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReuseDataReport6Choice
{
    /// <summary>
    /// Indicates a cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to reporting requirements but was reported to a trade repository by mistake.
    /// </summary>
    [IsoId("_MzHkQ8K8EeuMhqg3CsEu6Q")]
    [DisplayName("Error")]
    [IsoXmlTag("Err")]
    public record Error : ReuseDataReport6Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_Gau70c2yEeudu8_R18uRnA")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_Gau7082yEeudu8_R18uRnA")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_Gau71c2yEeudu8_R18uRnA")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required CounterpartyData87 Counterparty { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_Gau7182yEeudu8_R18uRnA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
