// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PresentationMedium1Choice
{
    /// <summary>
    /// Presentation medium.
    /// </summary>
    [IsoId("_93_1pHltEeG7BsjMvd1mEw_1115260938")]
    [DisplayName("Code")]
    public record Code : PresentationMedium1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the presentation medium.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PresentationMedium1Code Value { get; init; }
    }
}
