// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConversionTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of conversion.
    /// </summary>
    [IsoId("_Q36dcNp-Ed-ak6NoX_4Aeg_759734403")]
    [DisplayName("Code")]
    public record Code : ConversionTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of conversion.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConversionType1Code Value { get; init; }
    }
}
