// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Rates1Choice
{
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_OvhyoHg2EeuXJdYjLmnO3w")]
    [DisplayName("Fixed")]
    public record Fixed : Rates1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Fxd")]
        public required NoReasonCode Value { get; init; }
    }
}
