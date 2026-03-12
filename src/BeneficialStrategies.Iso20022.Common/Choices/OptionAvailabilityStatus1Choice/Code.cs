// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionAvailabilityStatus1Choice
{
    /// <summary>
    /// Standard code to specify the status of the option availability.
    /// </summary>
    [IsoId("_Q0L0ANp-Ed-ak6NoX_4Aeg_-123889376")]
    [DisplayName("Code")]
    public partial record Code : OptionAvailabilityStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the option availability.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionAvailabilityStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
