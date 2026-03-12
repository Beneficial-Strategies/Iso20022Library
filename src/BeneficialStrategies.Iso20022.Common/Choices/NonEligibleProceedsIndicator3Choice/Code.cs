// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NonEligibleProceedsIndicator3Choice
{
    /// <summary>
    /// Standard code to specify information regarding the non eligibility of the outturn resources.
    /// </summary>
    [IsoId("_M7XQoUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public partial record Code : NonEligibleProceedsIndicator3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information regarding the non eligibility of the outturn resources.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NonEligibleProceedsIndicator1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
