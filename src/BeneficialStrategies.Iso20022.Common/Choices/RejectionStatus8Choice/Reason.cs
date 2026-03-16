// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus8Choice
{
    /// <summary>
    /// Specifies the reason of the RejectionStatus.
    /// </summary>
    [IsoId("_0kkl0AlIEeGATtfOBToyew_832896781")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionStatus8Choice_
    {
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_0kRD0QlIEeGATtfOBToyew_35630539")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason11Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_0kRD0glIEeGATtfOBToyew_-1532269853")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
