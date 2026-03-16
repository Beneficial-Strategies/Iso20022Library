// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat1Choice
{
    /// <summary>
    /// Standard code to specify the additional business process linked to a corporate action event.
    /// </summary>
    [IsoId("_Q3dxgdp-Ed-ak6NoX_4Aeg_-250323406")]
    [DisplayName("Code")]
    public record Code : AdditionalBusinessProcessFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the additional business process linked to a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess1Code Value { get; init; }
    }
}
