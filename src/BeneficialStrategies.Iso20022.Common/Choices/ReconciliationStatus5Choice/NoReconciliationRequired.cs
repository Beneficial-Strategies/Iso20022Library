// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReconciliationStatus5Choice
{
    /// <summary>
    /// Information that no reconciliation is required.
    /// </summary>
    [IsoId("_C1J2gf_oEemm3skPVSMJQg")]
    [DisplayName("No Reconciliation Required")]
    public partial record NoReconciliationRequired : ReconciliationStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoRcncltnReqrd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
