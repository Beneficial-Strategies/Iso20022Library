// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EnabledStatusReason1Choice
{
    /// <summary>
    /// Reason for the enabled account status.
    /// </summary>
    [IsoId("_5-mGsEy9EeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    public record Reason : EnabledStatusReason1Choice_
    {
        /// <summary>
        /// Reason for the enabled account status.
        /// </summary>
        [IsoId("_JPoAwEy-EeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required EnabledStatusReason2Choice_ Code { get; init; }

        /// <summary>
        /// Additional information about the reason for the enabled account status.
        /// </summary>
        [IsoId("_MI23sEy-EeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
