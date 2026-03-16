// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FormOfSecurity8Choice
{
    /// <summary>
    /// Form of security expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_dqcAgeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : FormOfSecurity8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Form of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FormOfSecurity1Code Value { get; init; }
    }
}
