// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes3Choice
{
    /// <summary>
    /// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
    /// </summary>
    [IsoId("_KUIpc4G-EeaalK9UbuVGFw")]
    [DisplayName("Other")]
    public record Other : FinancialInstrumentAttributes3Choice_
    {
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_KeZ_wYG-EeaalK9UbuVGFw")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription11 FinancialInstrumentGeneralAttributes { get; init; }

        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_KeZ_w4G-EeaalK9UbuVGFw")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument4? DebtInstrumentAttributes { get; init; }

        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_KeZ_xYG-EeaalK9UbuVGFw")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; }
    }
}
