// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FrequencyRateFixing1Choice
{
    /// <summary>
    /// Specific number of days assigned for the frequency fixing of the rate.
    /// </summary>
    [IsoId("_GfUYMI9QEeqMo4JxiuZGSw")]
    [DisplayName("Number Of Days")]
    public record NumberOfDays : FrequencyRateFixing1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 3 digits.
        /// </summary>
        [IsoXmlTag("NbOfDays")]
        [IsoSimpleType(IsoSimpleType.Max3NumericText)]
        public required IsoMax3NumericText Value { get; init; }
    }
}
