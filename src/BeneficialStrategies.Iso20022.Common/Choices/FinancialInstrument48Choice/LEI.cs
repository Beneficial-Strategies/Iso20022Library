// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument48Choice
{
    /// <summary>
    /// The LEI code of the issuer where the instrument is referring to an issuer rather than one single instrument.
    /// </summary>
    [IsoId("_HYrJU35aEea2k7EBUopqxw")]
    [DisplayName("LEI")]
    public record LEI : FinancialInstrument48Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
