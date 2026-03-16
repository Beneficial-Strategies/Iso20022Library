// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExecutingParty2Choice
{
    /// <summary>
    /// Client.
    /// </summary>
    [DisplayName("Client")]
    public partial record Client : ExecutingParty2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Clnt")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
