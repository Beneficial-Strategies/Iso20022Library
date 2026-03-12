// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus5Choice
{
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [IsoId("_w2B8NEABEeCaq78Ig8ATcA")]
    [DisplayName("Code")]
    public partial record Code : SettlementStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status of settlement of an instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesSettlementStatus2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
