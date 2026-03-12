// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AllocationSatus1Choice
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_UX39MNp-Ed-ak6NoX_4Aeg_-2141684730")]
    [DisplayName("Code")]
    public partial record Code : AllocationSatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of allocation of collateral to cover the instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllocationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
