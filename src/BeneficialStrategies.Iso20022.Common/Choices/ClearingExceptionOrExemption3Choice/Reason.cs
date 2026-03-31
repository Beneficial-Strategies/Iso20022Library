// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingExceptionOrExemption3Choice
{
    /// <summary>
    /// No reason to report or no reason available to report.
    /// </summary>
    [IsoId("_AjSxcZPuEey0rJ3Gl6WZVA")]
    [DisplayName("Reason")]
    public record Reason : ClearingExceptionOrExemption3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required NoReasonCode Value { get; init; }
    }
}
