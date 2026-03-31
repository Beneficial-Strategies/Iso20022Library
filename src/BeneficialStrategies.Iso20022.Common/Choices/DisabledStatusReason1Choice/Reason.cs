// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisabledStatusReason1Choice
{
    /// <summary>
    /// Reason for the disabled account status.
    /// </summary>
    [IsoId("_R5FfA0zAEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : DisabledStatusReason1Choice_
    {
        /// <summary>
        /// Reason for the disabled account status.
        /// </summary>
        [IsoId("_aMFP8UzAEeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DisabledStatusReason2Choice_ Code { get; init; }

        /// <summary>
        /// Additional information about the reason for the disabled account status.
        /// </summary>
        [IsoId("_aMFP80zAEeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
