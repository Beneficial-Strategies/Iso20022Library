// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralStatus2Choice
{
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code.
    /// </summary>
    [IsoId("_hztsoMX4EeiSF9q-coWegA")]
    [DisplayName("Code")]
    public record Code : CollateralStatus2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExecutionStatus1Code Value { get; init; }
    }
}
