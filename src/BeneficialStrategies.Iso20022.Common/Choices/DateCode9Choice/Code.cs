// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateCode9Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_QnElENp-Ed-ak6NoX_4Aeg_186332043")]
    [DisplayName("Code")]
    public record Code : DateCode9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is open.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType2Code Value { get; init; }
    }
}
