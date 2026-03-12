// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReconciliationStatus5Choice
{
    /// <summary>
    /// Data to be reconciled.
    /// </summary>
    [IsoId("_C1J2g__oEemm3skPVSMJQg")]
    [DisplayName("Reporting Data")]
    public partial record ReportingData : ReconciliationStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
