// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters1Choice
{
    /// <summary>
    /// Message to send for the send message command.
    /// </summary>
    [IsoId("_0OWO8IqLEeSRT5rEzcAHEw")]
    [DisplayName("Expected Message Function")]
    public record ExpectedMessageFunction : ATMCommandParameters1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the type of process requested by the host to an ATM.
        /// </summary>
        [IsoXmlTag("XpctdMsgFctn")]
        public required MessageFunction8Code Value { get; init; }
    }
}
