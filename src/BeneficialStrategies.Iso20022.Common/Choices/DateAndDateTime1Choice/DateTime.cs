// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTime1Choice
{
    /// <summary>
    /// Numeric representation of time of the day and the day of the month and year.
    /// </summary>
    [IsoId("_Axs_MtokEeC60axPepSq7g_1709003254")]
    [DisplayName("Date Time")]
    public record DateTime : DateAndDateTime1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
        /// </summary>
        [IsoXmlTag("DtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime Value { get; init; }
    }
}
