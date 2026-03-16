// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProformaStatusReason2Choice
{
    /// <summary>
    /// Reason for the enabled account status expressed as a code.
    /// </summary>
    [IsoId("_MfWS0UzDEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public record Code : ProformaStatusReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for proforma status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProformaStatusReason1Code Value { get; init; }
    }
}
