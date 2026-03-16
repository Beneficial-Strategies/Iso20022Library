// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes4Choice
{
    /// <summary>
    /// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
    /// </summary>
    [IsoId("_GMbzg53CEeuwmdq0KtnICg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : FinancialInstrumentAttributes4Choice_
    {
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_sAOv4Z3CEeuwmdq0KtnICg")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription20 FinancialInstrumentGeneralAttributes { get; init; }

        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_sAOv453CEeuwmdq0KtnICg")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument4? DebtInstrumentAttributes { get; init; }

        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_sAOv5Z3CEeuwmdq0KtnICg")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public required DerivativeInstrument9 DerivativeInstrumentAttributes { get; init; }
    }
}
