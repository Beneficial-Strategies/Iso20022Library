// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime21Choice
{
    /// <summary>
    /// Indicates that the contract is cleared.
    /// </summary>
    [IsoId("_91accwtuEe2eQ-C-GTDpFA")]
    [DisplayName("Reason")]
    public partial record Reason : ClearingPartyAndTime21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
