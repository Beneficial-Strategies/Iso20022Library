// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionNarrative1Choice
{
    /// <summary>
    /// Standard code to specify the narrative type of the message.
    /// </summary>
    [IsoId("_Q10yx9p-Ed-ak6NoX_4Aeg_-1519257938")]
    [DisplayName("Code")]
    public record Code : CorporateActionNarrative1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the narrative type of a corporate action.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionNarrative1Code Value { get; init; }
    }
}
