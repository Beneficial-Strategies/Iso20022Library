// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_C2YFtSRhEeO8sskhVI3IDA")]
    [DisplayName("Cancellation Reason")]
    public partial record CancellationReason : Reason12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlRsn")]
        public required CancellationReason9Choice_ Value { get; init; }
    }
}
