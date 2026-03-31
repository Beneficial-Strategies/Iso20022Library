// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReconciliationStatus8Choice
{
    /// <summary>
    /// Information that no reconciliation is required.
    /// </summary>
    [IsoId("_Av6qYcK3EeuFNp8LZAnorg")]
    [DisplayName("No Reconciliation Required")]
    public record NoReconciliationRequired : ReconciliationStatus8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoRcncltnReqrd")]
        public required NoReasonCode Value { get; init; }
    }
}
