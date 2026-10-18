// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_U4Y95ZdgEea1K6JAcAwoVg")]
    [DisplayName("Code")]
    public partial record Code : AuthenticationChannel1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalAuthenticationChannel1Code Value { get; init; }
    }
}
