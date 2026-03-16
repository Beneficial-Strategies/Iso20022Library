// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice
{
    /// <summary>
    /// Execution type is executed based on a time trigger.
    /// </summary>
    [IsoId("_750BgKMgEeCJ6YNENx4h-w_274414262")]
    [DisplayName("Time")]
    public record Time : ExecutionType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar day expressed in either UTC time format (hh:mm:ss.sssZ), local time with UTC offset format (hh:mm:ss.sss+/-hh:mm), or local time format (hh:mm:ss.sss). These representations are defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
        /// </summary>
        [IsoXmlTag("Tm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        public required IsoISOTime Value { get; init; }
    }
}
