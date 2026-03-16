// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatusReason1Choice
{
    /// <summary>
    /// Reason for the pending account status.
    /// </summary>
    [IsoId("_xwsJw0zAEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    public record Reason : PendingStatusReason1Choice_
    {
        /// <summary>
        /// Reason for the pending account status.
        /// </summary>
        [IsoId("_8fTBgUzAEeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingStatusReason2Choice_ Code { get; init; }

        /// <summary>
        /// Additional information about the reason for the pending account status.
        /// </summary>
        [IsoId("_8fTBg0zAEeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
