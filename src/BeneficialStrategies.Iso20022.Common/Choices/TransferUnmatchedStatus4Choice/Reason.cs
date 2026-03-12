// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferUnmatchedStatus4Choice
{
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [IsoId("_k75sI5M5EemKz5EOjv82iQ")]
    [DisplayName("Reason")]
    public partial record Reason : TransferUnmatchedStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required TransferUnmatchedReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
