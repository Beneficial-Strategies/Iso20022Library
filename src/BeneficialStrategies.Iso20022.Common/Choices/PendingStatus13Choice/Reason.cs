// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus13Choice
{
    /// <summary>
    /// Specifies the reason of the PendingStatus.
    /// </summary>
    [IsoId("_5y9kUf7qEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus13Choice_
    {
        /// <summary>
        /// Specifies the reason why a cancellation request sent for the related instruction is pending.
        /// </summary>
        [IsoId("_UYoLINp-Ed-ak6NoX_4Aeg_-1305472702")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UYoLIdp-Ed-ak6NoX_4Aeg_1910911017")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
