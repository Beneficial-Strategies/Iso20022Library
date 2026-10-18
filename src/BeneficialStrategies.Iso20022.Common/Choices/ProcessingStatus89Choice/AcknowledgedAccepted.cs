// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus89Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_SeYDEStYEeyhipY4f42fZQ")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ProcessingStatus89Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus24Choice_ Value { get; init; }
    }
}
