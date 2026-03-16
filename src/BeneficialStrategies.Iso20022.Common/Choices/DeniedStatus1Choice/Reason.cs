// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus1Choice
{
    /// <summary>
    /// Specifies the reason of the DeniedStatus.
    /// </summary>
    [IsoId("_UWPlhNp-Ed-ak6NoX_4Aeg_-1189823818")]
    [DisplayName("Reason")]
    public record Reason : DeniedStatus1Choice_
    {
        /// <summary>
        /// Specifies the reason why the request has a denied status.
        /// </summary>
        [IsoId("_UWPlgNp-Ed-ak6NoX_4Aeg_-861882406")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DeniedReason3Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UWPlgdp-Ed-ak6NoX_4Aeg_475265958")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
