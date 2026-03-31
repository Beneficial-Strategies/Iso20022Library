// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralCancellationType1Choice
{
    /// <summary>
    /// Provides the cancellation reason using an ISO 20022 code.
    /// </summary>
    [IsoId("_QmxqINp-Ed-ak6NoX_4Aeg_-132072527")]
    [DisplayName("Code")]
    public record Code : CollateralCancellationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction/request has been cancelled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CollateralManagementCancellationReason1Code Value { get; init; }
    }
}
