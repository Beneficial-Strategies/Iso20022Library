// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used by the security scheme update command.
    /// </summary>
    [IsoId("_3rN4AItHEeSxlKlAGYErFg")]
    [DisplayName("Required Security Scheme")]
    public record RequiredSecurityScheme : ATMCommandParameters2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Key exchange security schemes implemented in the hardware security module of the ATM.
        /// </summary>
        [IsoXmlTag("ReqrdSctySchme")]
        public required ATMSecurityScheme2Code Value { get; init; }
    }
}
