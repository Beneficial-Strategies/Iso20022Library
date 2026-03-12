// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementSystemMethod5Choice
{
    /// <summary>
    /// Settlement system expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TKlRZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : SettlementSystemMethod5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementSystemMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
