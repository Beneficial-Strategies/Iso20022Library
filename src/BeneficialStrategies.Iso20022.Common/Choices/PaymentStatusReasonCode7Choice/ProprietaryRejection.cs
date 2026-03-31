// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Defines the reason that has been used by the Target2 SSP system to reject the transaction.
    /// </summary>
    [IsoId("_Ny9Dy5lPEee-Zps0fZQaFQ")]
    [DisplayName("Proprietary Rejection")]
    [IsoXmlTag("PrtryRjctn")]
    public record ProprietaryRejection : PaymentStatusReasonCode7Choice_
    {
        /// <summary>
        /// Defines the reason why the Target2 SSP system has rejected the transaction.
        /// </summary>
        [IsoId("_N7lbUZlPEee-Zps0fZQaFQ")]
        [DisplayName("Proprietary Status Reason")]
        [IsoXmlTag("PrtryStsRsn")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; }

        /// <summary>
        /// Provides detailed information about the reason why the Target2 SSP system has rejected the transaction.
        /// </summary>
        [IsoId("_N7lbU5lPEee-Zps0fZQaFQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public required IsoMax256Text Reason { get; init; }
    }
}
