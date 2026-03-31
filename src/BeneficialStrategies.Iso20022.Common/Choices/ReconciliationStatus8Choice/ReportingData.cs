// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReconciliationStatus8Choice
{
    /// <summary>
    /// Data to be reconciled.
    /// </summary>
    [IsoId("_Av6qY8K3EeuFNp8LZAnorg")]
    [DisplayName("Reporting Data")]
    public record ReportingData : ReconciliationStatus8Choice_ { }
}
