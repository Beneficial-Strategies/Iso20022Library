// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BlockTrade3Choice
{
    /// <summary>
    /// Block parent or child information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Aa5oxdokEeC60axPepSq7g_-766772377")]
    [DisplayName("Code")]
    public partial record Code : BlockTrade3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the instruction is the parent or a children of a block trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BlockTrade1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
