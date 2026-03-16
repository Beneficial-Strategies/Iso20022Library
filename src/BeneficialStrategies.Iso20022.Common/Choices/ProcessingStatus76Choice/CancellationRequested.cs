// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus76Choice
{
    /// <summary>
    /// Cancellation request from your counterparty for this transaction is pending waiting for your cancellation request or consent.
    /// </summary>
    [IsoId("_ukeMD_fXEeiNZp_PtLohLw")]
    [DisplayName("Cancellation Requested")]
    [IsoXmlTag("CxlReqd")]
    public record CancellationRequested : ProcessingStatus76Choice_
    {
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_ceme3ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification47? Reason { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_ceme5ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
