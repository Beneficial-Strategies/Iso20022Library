// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement7Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_RMPsUzs-EeWRTLSN0i0tng")]
    [DisplayName("Status Advice")]
    public partial record StatusAdvice : StatusOrStatement7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_QK8AVTs-EeWRTLSN0i0tng")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber5Choice_ Number { get; init; } 
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_QK8AXTs-EeWRTLSN0i0tng")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification15> References { get; init; } = new ValueList<Identification15>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _QK8AXTs-EeWRTLSN0i0tng
        
        
        #nullable disable
        
    }
}
