// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDateCode8Choice
{
    /// <summary>
    /// Settlement date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_42QF8TtKEeWRTLSN0i0tng")]
    [DisplayName("Code")]
    public record Code : SettlementDateCode8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType4Code Value { get; init; }
    }
}
