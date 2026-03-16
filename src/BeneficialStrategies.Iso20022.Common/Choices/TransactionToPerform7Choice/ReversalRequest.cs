// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform7Choice
{
    /// <summary>
    /// Reversal Request.
    /// </summary>
    [DisplayName("Reversal Request")]
    public partial record ReversalRequest : TransactionToPerform7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RvslReq")]
        public required ReversalRequest7 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
