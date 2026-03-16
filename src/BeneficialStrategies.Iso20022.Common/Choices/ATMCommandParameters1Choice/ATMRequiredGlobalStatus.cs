// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters1Choice
{
    /// <summary>
    /// Required status of the ATM, parameters of the status update command.
    /// </summary>
    [IsoId("_w2lB4IqLEeSRT5rEzcAHEw")]
    [DisplayName("ATM Required Global Status")]
    public record ATMRequiredGlobalStatus : ATMCommandParameters1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Status of the ATM.
        /// </summary>
        [IsoXmlTag("ATMReqrdGblSts")]
        public required ATMStatus1Code Value { get; init; }
    }
}
