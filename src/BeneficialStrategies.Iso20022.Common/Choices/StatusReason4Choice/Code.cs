// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusReason4Choice
{
    /// <summary>
    /// Reason for the status in a coded form.
    /// </summary>
    [IsoId("_TPdjptp-Ed-ak6NoX_4Aeg_46429953")]
    [DisplayName("Code")]
    public record Code : StatusReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the coded reason for the financing status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancingStatusReason1Code Value { get; init; }
    }
}
