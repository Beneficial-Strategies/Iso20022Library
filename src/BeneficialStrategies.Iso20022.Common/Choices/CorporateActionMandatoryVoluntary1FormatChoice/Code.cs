// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionMandatoryVoluntary1FormatChoice
{
    /// <summary>
    /// Standard code to specify whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_RmZ7I9p-Ed-ak6NoX_4Aeg_-1747006967")]
    [DisplayName("Code")]
    public record Code : CorporateActionMandatoryVoluntary1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the event is mandatory, mandatory with options or voluntary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionMandatoryVoluntary1Code Value { get; init; }
    }
}
