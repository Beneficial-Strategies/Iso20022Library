// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementInstructionReason1Choice
{
    /// <summary>
    /// Settlement instruction reason expressed as a code.
    /// </summary>
    [IsoId("_cw2NwCCsEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public partial record Code : SettlementInstructionReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementInstructionReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
