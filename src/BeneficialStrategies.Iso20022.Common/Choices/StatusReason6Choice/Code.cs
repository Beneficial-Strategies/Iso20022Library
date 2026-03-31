// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice
{
    /// <summary>
    /// Reason for the status, as published in an external reason code list.
    /// </summary>
    [IsoId("_TRGiZ9p-Ed-ak6NoX_4Aeg_-1877638996")]
    [DisplayName("Code")]
    public record Code : StatusReason6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status reason, as published in an external status reason code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalStatusReason1Code Value { get; init; }
    }
}
