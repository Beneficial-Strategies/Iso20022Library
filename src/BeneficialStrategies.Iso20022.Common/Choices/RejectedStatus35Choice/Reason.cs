// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus35Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_5Bm5Ge6KEeqc-LCjwLsUVg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectedStatus35Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been rejected.
        /// </summary>
        [IsoId("_5rHJE-6KEeqc-LCjwLsUVg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason35Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_5rHJG-6KEeqc-LCjwLsUVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
