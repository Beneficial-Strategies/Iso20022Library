// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentOrRejectionReason2Choice
{
    /// <summary>
    /// Specifies the reason why the counterparty response has a rejection status.
    /// </summary>
    [IsoId("_0fzakAlIEeGATtfOBToyew_-2131217638")]
    [DisplayName("Code")]
    public record Code : ConsentOrRejectionReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of counterparty&apos;s action the response is related to.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CounterpartyResponseStatusReason1Code Value { get; init; }
    }
}
