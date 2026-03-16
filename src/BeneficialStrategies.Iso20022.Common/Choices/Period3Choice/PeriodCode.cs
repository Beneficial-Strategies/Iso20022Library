// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period3Choice
{
    /// <summary>
    /// Standard code to specify the type of period.
    /// </summary>
    [IsoId("_Nt3jdeENEd-qUMZtd_eZuQ")]
    [DisplayName("Period Code")]
    public record PeriodCode : Period3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("PrdCd")]
        public required DateType8Code Value { get; init; }
    }
}
