// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus4Choice
{
    /// <summary>
    /// Specifies the reason of the CancellationStatus.
    /// </summary>
    [IsoId("_UZEQBdp-Ed-ak6NoX_4Aeg_-1976825754")]
    [DisplayName("Reason")]
    public record Reason : CancellationStatus4Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_UZEQAdp-Ed-ak6NoX_4Aeg_644022432")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason5Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UZEQAtp-Ed-ak6NoX_4Aeg_-1472361575")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
