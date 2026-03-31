// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus7Choice
{
    /// <summary>
    /// Specifies the reason of the rejection or repair status.
    /// </summary>
    [IsoId("_0j0X5QlIEeGATtfOBToyew_881011952")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionStatus7Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_0j0X4QlIEeGATtfOBToyew_292064549")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ConsentOrRejectionReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_0j0X4glIEeGATtfOBToyew_1200659283")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
