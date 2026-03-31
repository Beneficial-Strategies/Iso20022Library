// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.WaivingInstruction1Choice
{
    /// <summary>
    /// Type of waiving instruction expressed as a code.
    /// </summary>
    [IsoId("_YvhDsBuDEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public record Code : WaivingInstruction1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the form of the rebate when commission is waived.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WaivingInstruction1Code Value { get; init; }
    }
}
