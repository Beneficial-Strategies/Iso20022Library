// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConfirmationStatus1Choice
{
    /// <summary>
    /// Status of the order confirmation amendment is rejected.
    /// </summary>
    [IsoId("_1BFlFEhCEea8pJjypp-yMQ")]
    [DisplayName("Amendment Rejected")]
    public record AmendmentRejected : ConfirmationStatus1Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_FJAq40hDEea8pJjypp-yMQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ConfirmationRejectedReason1Choice_? Reason { get; init; }

        /// <summary>
        /// Additional information about the rejected reason.
        /// </summary>
        [IsoId("__OYdI3ZxEeaN2c674jyTxQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
