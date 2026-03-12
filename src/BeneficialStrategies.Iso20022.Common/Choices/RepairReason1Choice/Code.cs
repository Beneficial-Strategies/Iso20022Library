// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepairReason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_UYoLJtp-Ed-ak6NoX_4Aeg_-1899691017")]
    [DisplayName("Code")]
    public partial record Code : RepairReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the settlement instruction has a repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepairReason4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
