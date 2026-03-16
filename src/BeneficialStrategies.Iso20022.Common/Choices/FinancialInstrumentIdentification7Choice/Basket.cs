// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification7Choice
{
    /// <summary>
    /// Instrument consists of multiple instruments.
    /// </summary>
    [IsoId("_LHTy04G-EeaalK9UbuVGFw")]
    [DisplayName("Basket")]
    [IsoXmlTag("Bskt")]
    public record Basket : FinancialInstrumentIdentification7Choice_
    {
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_LS6l4YG-EeaalK9UbuVGFw")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; }

        /// <summary>
        /// Index on which the financial instrument is based.
        /// </summary>
        [IsoId("_LS6l44G-EeaalK9UbuVGFw")]
        [DisplayName("Index")]
        [IsoXmlTag("Indx")]
        public FinancialInstrument58? Index { get; init; }
    }
}
