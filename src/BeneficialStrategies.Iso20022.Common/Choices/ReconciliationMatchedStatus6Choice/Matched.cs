// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReconciliationMatchedStatus6Choice
{
    /// <summary>
    /// Indication that the reports subject of reconciliation match.
    /// </summary>
    [IsoId("_C44f8f_oEemm3skPVSMJQg")]
    [DisplayName("Matched")]
    public record Matched : ReconciliationMatchedStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Mtchd")]
        public required NoReasonCode Value { get; init; }
    }
}
