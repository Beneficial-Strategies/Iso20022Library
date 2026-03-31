// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionBarrierLevel1Choice
{
    /// <summary>
    /// Multiple.
    /// </summary>
    [DisplayName("Multiple")]
    public record Multiple : OptionBarrierLevel1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Mltpl")]
        public required OptionMultipleBarrierLevels1 Value { get; init; }
    }
}
