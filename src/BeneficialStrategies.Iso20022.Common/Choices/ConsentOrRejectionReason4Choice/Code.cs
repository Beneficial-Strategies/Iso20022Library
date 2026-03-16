// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentOrRejectionReason4Choice
{
    /// <summary>
    /// Specifies the reason why the counterparty response has a rejection status.
    /// </summary>
    [IsoId("_n--vQTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Code")]
    public record Code : ConsentOrRejectionReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of counterparty&apos;s action the response is related to.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CounterpartyResponseStatusReason1Code Value { get; init; }
    }
}
