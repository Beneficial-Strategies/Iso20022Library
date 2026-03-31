// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PreviousYear2Choice
{
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_dclD5bNBEeex65jrLOfSTw")]
    [DisplayName("Specific Previous Years")]
    public record SpecificPreviousYears : PreviousYear2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Year represented by YYYY (ISO 8601).
        /// </summary>
        [IsoXmlTag("SpcfcPrvsYrs")]
        [IsoSimpleType(IsoSimpleType.ISOYear)]
        public required IsoISOYear Value { get; init; }
    }
}
