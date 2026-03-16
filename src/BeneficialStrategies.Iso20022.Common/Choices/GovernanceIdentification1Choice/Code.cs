// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GovernanceIdentification1Choice
{
    /// <summary>
    /// Governance identification information.
    /// </summary>
    [IsoId("_929T0XltEeG7BsjMvd1mEw_-1110032848")]
    [DisplayName("Code")]
    public record Code : GovernanceIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the identification of the rules and laws governing the undertaking.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GovernanceIdentification1Code Value { get; init; }
    }
}
