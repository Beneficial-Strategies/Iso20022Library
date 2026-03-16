// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.WaivingInstruction2Choice
{
    /// <summary>
    /// Type of discount or waiving expressed as a code.
    /// </summary>
    [IsoId("_PL1e8ViPEeaMNZxYNthMeA")]
    [DisplayName("Code")]
    public record Code : WaivingInstruction2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the form of the rebate when commission is waived.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WaivingInstruction1Code Value { get; init; }
    }
}
