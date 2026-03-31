// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice
{
    /// <summary>
    /// The trade is fully executed and the confirmation is sent.
    /// </summary>
    [IsoId("_A4_6ANokEeC60axPepSq7g_-367909471")]
    [DisplayName("Fully Executed Confirmation Sent")]
    [IsoXmlTag("FullyExctdConfSnt")]
    public record FullyExecutedConfirmationSent : ProcessingStatus17Choice_
    {
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_UatOxdp-Ed-ak6NoX_4Aeg_-1135929071")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification20? Reason { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_UatOxtp-Ed-ak6NoX_4Aeg_-1133156666")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
