// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportItemRejectionReason1Choice
{
    /// <summary>
    /// Status reason expressed as a code.
    /// </summary>
    [IsoId("_hlx-c73REeO2FLWuu_JIqg")]
    [DisplayName("Code")]
    public partial record Code : ReportItemRejectionReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the report item is rejected.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required HoldingRejectionReason41Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
