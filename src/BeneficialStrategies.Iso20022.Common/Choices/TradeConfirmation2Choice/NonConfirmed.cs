// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation2Choice
{
    /// <summary>
    /// Indicates that contract was not confirmed.
    /// </summary>
    [IsoId("_qo0sYwFXEeaDfK-zDSyB6A")]
    [DisplayName("Non Confirmed")]
    public partial record NonConfirmed : TradeConfirmation2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies that the contract remains unconfirmed.
        /// </summary>
        [IsoId("_8sHJ5w27EeWmAKKPnqYEVQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required TradeConfirmationType2Code Type { get; init; } 
        
        
        #nullable disable
        
    }
}
