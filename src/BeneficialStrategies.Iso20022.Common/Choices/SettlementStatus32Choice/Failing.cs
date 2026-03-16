// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus32Choice
{
    /// <summary>
    /// Failing.
    /// </summary>
    [DisplayName("Failing")]
    public partial record Failing : SettlementStatus32Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Flng")]
        public required FailingStatus15Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
