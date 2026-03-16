// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the frequency of the corporate action event.
    /// </summary>
    [IsoId("_Q36dc9p-Ed-ak6NoX_4Aeg_-1957267186")]
    [DisplayName("Code")]
    public record Code : DividendTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the frequency of a CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType1Code Value { get; init; }
    }
}
