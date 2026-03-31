// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice
{
    /// <summary>
    /// Infrastructure through which the payment instruction is processed, as published in an external clearing system identification code list.
    /// </summary>
    [IsoId("_TMVXJtp-Ed-ak6NoX_4Aeg_948374929")]
    [DisplayName("Code")]
    public record Code : ClearingSystemIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cash clearing system, as published in an external cash clearing system code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCashClearingSystem1Code Value { get; init; }
    }
}
