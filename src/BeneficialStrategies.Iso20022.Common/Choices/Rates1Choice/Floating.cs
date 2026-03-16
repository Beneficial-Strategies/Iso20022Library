// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Rates1Choice
{
    /// <summary>
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_VdT5QHg2EeuXJdYjLmnO3w")]
    [DisplayName("Floating")]
    public record Floating : Rates1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Fltg")]
        public required ExternalRatesAndTenors1Code Value { get; init; }
    }
}
