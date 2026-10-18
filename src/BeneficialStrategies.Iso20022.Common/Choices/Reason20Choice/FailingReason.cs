// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason20Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// </summary>
    [IsoId("_gAQ5jzi8Eeydid5dcNPKvg")]
    [DisplayName("Failing Reason")]
    public partial record FailingReason : Reason20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FlngRsn")]
        public required FailingReason15Choice_ Value { get; init; }
    }
}
