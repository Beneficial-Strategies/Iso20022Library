// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PreviousYear2Choice
{
    /// <summary>
    /// Selection of all investment plans.
    /// </summary>
    [IsoId("_dclD47NBEeex65jrLOfSTw")]
    [DisplayName("All Previous Years")]
    public record AllPreviousYears : PreviousYear2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the investment plan issued during all the previous years have to be transferred.
        /// </summary>
        [IsoXmlTag("AllPrvsYrs")]
        [IsoSimpleType(IsoSimpleType.PreviousAll)]
        public required IsoPreviousAll Value { get; init; }
    }
}
