// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat12Choice
{
    /// <summary>
    /// Date not specified, for example, the date is unknown.
    /// </summary>
    [IsoId("_T6Em69p-Ed-ak6NoX_4Aeg_-1991979997")]
    [DisplayName("Not Specified Date")]
    public record NotSpecifiedDate : DateFormat12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("NotSpcfdDt")]
        public required DateType6Code Value { get; init; }
    }
}
