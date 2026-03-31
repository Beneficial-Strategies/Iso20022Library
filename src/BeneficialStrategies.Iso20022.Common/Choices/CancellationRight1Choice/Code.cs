// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationRight1Choice
{
    /// <summary>
    /// Cancellation right expressed as a code.
    /// </summary>
    [IsoId("_EJe7UThPEeaTjZWmPo-9OA")]
    [DisplayName("Code")]
    public record Code : CancellationRight1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationRight1Code Value { get; init; }
    }
}
