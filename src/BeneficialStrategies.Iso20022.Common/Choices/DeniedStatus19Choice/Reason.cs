// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus19Choice
{
    /// <summary>
    /// Specifies the reason of the denied status.
    /// </summary>
    [IsoId("_6GXkN5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : DeniedStatus19Choice_
    {
        /// <summary>
        /// Specifies the reason why the request has a denied status.
        /// </summary>
        [IsoId("_f0zqwZkNEeWn2ur3BXxtdg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DeniedReason24Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_f0zqyZkNEeWn2ur3BXxtdg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
