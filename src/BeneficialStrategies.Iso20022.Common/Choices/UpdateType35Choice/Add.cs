// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType35Choice
{
    /// <summary>
    /// Set of data requested to enrich a security.
    /// </summary>
    [IsoId("_QOJ0MZJKEeuAlLVx8pyt3w")]
    [DisplayName("Add")]
    [IsoXmlTag("Add")]
    public record Add : UpdateType35Choice_
    {
        /// <summary>
        /// Provides additional details about the financial instrument.
        /// </summary>
        [IsoId("_QKNvYZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Type")]
        [IsoXmlTag("FinInstrmTp")]
        public FinancialInstrument97? FinancialInstrumentType { get; init; }

        /// <summary>
        /// Provides details about the financial instrument attributes of a particular leg.
        /// </summary>
        [IsoId("_QKNvY5JKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public CommonFinancialInstrumentAttributes12? FinancialInstrumentAttributes { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_QKNvZZJKEeuAlLVx8pyt3w")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
