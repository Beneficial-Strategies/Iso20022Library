// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
    /// </summary>
    [IsoId("_CSq4NSGQEeW7gKYhAMEFCw")]
    [DisplayName("SEDOL")]
    public record SEDOL : SecurityIdentification23Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
        /// </summary>
        [IsoXmlTag("SEDOL")]
        [IsoSimpleType(IsoSimpleType.SEDOLIdentifier)]
        public required IsoSEDOLIdentifier Value { get; init; }
    }
}
