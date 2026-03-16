// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RiskLevel1Choice
{
    /// <summary>
    /// Risk level expressed as code.
    /// </summary>
    [IsoId("_oQId8BdxEeKYM7Bc71nDlA")]
    [DisplayName("Code")]
    public record Code : RiskLevel1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the risk level.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RiskLevel1Code Value { get; init; }
    }
}
