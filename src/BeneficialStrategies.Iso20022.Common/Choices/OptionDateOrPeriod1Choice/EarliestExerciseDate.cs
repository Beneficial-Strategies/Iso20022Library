// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionDateOrPeriod1Choice
{
    /// <summary>
    /// First date on which the call option or the put option can be exercised.
    /// </summary>
    [IsoId("_FBT62DU7EeWITbq5W8H-2w")]
    [DisplayName("Earliest Exercise Date")]
    public record EarliestExerciseDate : OptionDateOrPeriod1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
        /// </summary>
        [IsoXmlTag("EarlstExrcDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Value { get; init; }
    }
}
