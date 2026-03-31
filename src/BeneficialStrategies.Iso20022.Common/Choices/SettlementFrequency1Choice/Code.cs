// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementFrequency1Choice
{
    /// <summary>
    /// Settlement frequency expressed as a code.
    /// </summary>
    [IsoId("_nkfPUCDUEeWCLu74WLgP4w")]
    [DisplayName("Code")]
    public record Code : SettlementFrequency1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency10Code Value { get; init; }
    }
}
