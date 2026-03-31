// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat14Choice
{
    /// <summary>
    /// Standard code to specify the stage of the corporate action event.
    /// </summary>
    [IsoId("_ydC6I0GKEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventStageFormat14Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the CA lottery event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage4Code Value { get; init; }
    }
}
