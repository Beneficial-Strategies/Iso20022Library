// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat42Choice
{
    /// <summary>
    /// Year, month and day.
    /// </summary>
    [IsoId("_xXmZw5BrEeaGiLsfv6g8MA")]
    [DisplayName("Year Month Day")]
    public record YearMonthDay : DateFormat42Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
        /// </summary>
        [IsoXmlTag("YrMnthDay")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Value { get; init; }
    }
}
