// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnilateralSplit3Choice
{
    /// <summary>
    /// Unilateral split expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_e2Y7wTt4EeW638lNyHKv7A")]
    [DisplayName("Code")]
    public record Code : UnilateralSplit3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType5Code Value { get; init; }
    }
}
