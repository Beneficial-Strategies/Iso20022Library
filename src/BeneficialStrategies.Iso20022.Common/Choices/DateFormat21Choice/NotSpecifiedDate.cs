// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat21Choice
{
    /// <summary>
    /// Date not specified, for example, the date is unknown.
    /// </summary>
    [IsoId("_5PdBtfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Not Specified Date")]
    public record NotSpecifiedDate : DateFormat21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("NotSpcfdDt")]
        public required DateType8Code Value { get; init; }
    }
}
