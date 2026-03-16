// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice
{
    /// <summary>
    /// Parameters to be used by the security scheme update command.
    /// </summary>
    [IsoId("_htqcN12aEeekzJIz1JxYSQ")]
    [DisplayName("Required Security Scheme")]
    public record RequiredSecurityScheme : ATMCommandParameters3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Key exchange security schemes implemented in the hardware security module of the ATM.
        /// </summary>
        [IsoXmlTag("ReqrdSctySchme")]
        public required ATMSecurityScheme4Code Value { get; init; }
    }
}
