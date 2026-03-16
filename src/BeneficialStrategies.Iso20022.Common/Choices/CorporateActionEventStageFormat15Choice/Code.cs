// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStageFormat15Choice
{
    /// <summary>
    /// Standard code to specify the stage of the corporate action event.
    /// </summary>
    [IsoId("_cdS3X5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventStageFormat15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the CA lottery event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage4Code Value { get; init; }
    }
}
