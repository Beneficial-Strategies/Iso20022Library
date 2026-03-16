// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus17Choice
{
    /// <summary>
    /// Specifies the reason of the denied status.
    /// </summary>
    [IsoId("__pmdqTw9EeW3QqUkIQtIUA")]
    [DisplayName("Reason")]
    public record Reason : DeniedStatus17Choice_
    {
        /// <summary>
        /// Specifies the reason why the request has a denied status.
        /// </summary>
        [IsoId("_AKouITw-EeW3QqUkIQtIUA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DeniedReason17Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_AKouKTw-EeW3QqUkIQtIUA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
