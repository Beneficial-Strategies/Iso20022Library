// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExerciseDate1Choice
{
    /// <summary>
    /// Specifies the earliest unadjusted date during the exercise period on which an option can be exercised.
    /// ||Usage|: For European style options, the first possible exercise date is the same as the ExpirationDate.|
    /// For American style options, the first possible exercise date is the same as the ExecutionTimeStamp.|
    /// For Knock-in options, the first exercise date is reported when available.
    /// </summary>
    [IsoId("_Y7c_sgbBEeqrW7Meu5r3kQ")]
    [DisplayName("First Exercise Date")]
    public record FirstExerciseDate : ExerciseDate1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
        /// </summary>
        [IsoXmlTag("FrstExrcDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Value { get; init; }
    }
}
