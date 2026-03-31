// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingDenied1Choice
{
    /// <summary>
    /// Specifies the execution of a matching denial process.
    /// </summary>
    [IsoId("_UakE1dp-Ed-ak6NoX_4Aeg_-1792146341")]
    [DisplayName("Code")]
    public record Code : MatchingDenied1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the action to be performed on the matching process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MatchingProcess1Code Value { get; init; }
    }
}
