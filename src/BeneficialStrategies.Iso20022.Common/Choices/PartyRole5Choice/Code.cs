// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyRole5Choice
{
    /// <summary>
    /// Role expressed as a code.
    /// </summary>
    [IsoId("_pvNFUSDSEeWCLu74WLgP4w")]
    [DisplayName("Code")]
    public partial record Code : PartyRole5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party in the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PartyRole1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
