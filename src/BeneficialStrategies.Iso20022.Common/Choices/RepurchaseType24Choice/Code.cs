// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType24Choice
{
    /// <summary>
    /// Type of securities financing transaction process expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_pAgRUZwxEeazcsnODTksnQ")]
    [DisplayName("Code")]
    public record Code : RepurchaseType24Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of repurchase transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepurchaseType9Code Value { get; init; }
    }
}
