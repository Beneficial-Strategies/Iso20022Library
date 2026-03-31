// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason1Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_UX39Ntp-Ed-ak6NoX_4Aeg_1867774131")]
    [DisplayName("Code")]
    public record Code : DeniedReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the denied reason.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeniedReason5Code Value { get; init; }
    }
}
