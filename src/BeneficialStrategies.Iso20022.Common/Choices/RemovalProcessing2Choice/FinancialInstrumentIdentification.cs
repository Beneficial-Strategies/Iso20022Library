// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RemovalProcessing2Choice
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("__ioAQRIoEeyZaPkaPAzTvQ")]
    [DisplayName("Financial Instrument Identification")]
    public record FinancialInstrumentIdentification : RemovalProcessing2Choice_
    {
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_iDjE24lXEeWPSZi0kAOXhg")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; }

        /// <summary>
        /// Identification of a security by proprietary or domestic identification scheme.
        /// </summary>
        [IsoId("_iDjE3YlXEeWPSZi0kAOXhg")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        public OtherIdentification1? OtherIdentification { get; init; }

        /// <summary>
        /// Textual description of a security instrument.
        /// </summary>
        [IsoId("_iDjE34lXEeWPSZi0kAOXhg")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Description { get; init; }
    }
}
