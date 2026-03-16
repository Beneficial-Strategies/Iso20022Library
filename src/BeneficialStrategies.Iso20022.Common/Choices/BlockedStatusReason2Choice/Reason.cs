// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BlockedStatusReason2Choice
{
    /// <summary>
    /// Transaction type for which the account is blocked and the underlying reason.
    /// </summary>
    [IsoId("_8t7ZA11LEeagR5I1rq5oaw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : BlockedStatusReason2Choice_
    {
        /// <summary>
        /// Type of transaction for which the account has a blocked status.
        /// </summary>
        [IsoId("__4jh8V1LEeagR5I1rq5oaw")]
        [DisplayName("Transaction Type")]
        [IsoXmlTag("TxTp")]
        public required TransactionType5Choice_ TransactionType { get; init; }

        /// <summary>
        /// Indicates whether the account is blocked.
        /// </summary>
        [IsoId("_E6gY4V1MEeagR5I1rq5oaw")]
        [DisplayName("Blocked")]
        [IsoXmlTag("Blckd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Blocked { get; init; }

        /// <summary>
        /// Reason for the blocked status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public BlockedReason2Choice_? Value { get; init; }

        /// <summary>
        /// Additional information about the blocked account status.
        /// </summary>
        [IsoId("__4jh9V1LEeagR5I1rq5oaw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text AdditionalInformation { get; init; }
    }
}
