// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery4Choice
{
    /// <summary>
    /// Identification of constituents for a basket of indexes.
    /// </summary>
    [IsoId("_S7jvMJNfEeytjZlcgApf6A")]
    [DisplayName("Basket")]
    public record Basket : SecurityIdentificationQuery4Choice_
    {
        /// <summary>
        /// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
        /// </summary>
        [IsoId("_4uxSMJNeEeytjZlcgApf6A")]
        [DisplayName("Structurer")]
        [IsoXmlTag("Strr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? Structurer { get; init; }

        /// <summary>
        /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
        /// </summary>
        [IsoId("_8d5PUJNeEeytjZlcgApf6A")]
        [DisplayName("Identifier")]
        [IsoXmlTag("Idr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? Identifier { get; init; }

        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("__1ePIJNeEeytjZlcgApf6A")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? ISIN { get; init; }
    }
}
