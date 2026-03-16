// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosedStatusReason1Choice
{
    /// <summary>
    /// Reason for the closed account status.
    /// </summary>
    [IsoId("_U2WaA0zDEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : ClosedStatusReason1Choice_
    {
        /// <summary>
        /// Reason for the closed account status.
        /// </summary>
        [IsoId("_eUB1YUzDEeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ClosedStatusReason2Choice_ Code { get; init; }

        /// <summary>
        /// Additional information about the reason for the closed account status.
        /// </summary>
        [IsoId("_eUB1Y0zDEeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
