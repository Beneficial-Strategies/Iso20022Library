// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementUnitType3Choice
{
    /// <summary>
    /// Settlement unit type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_d8mHgeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : SettlementUnitType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of settlement foreseen for the security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementUnitType1Code Value { get; init; }
    }
}
