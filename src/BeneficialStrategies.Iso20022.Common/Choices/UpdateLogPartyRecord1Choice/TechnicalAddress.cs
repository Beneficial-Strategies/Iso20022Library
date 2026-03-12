// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Unique technical address to unambiguously identify a party for receiving messages from the executing system.
    /// </summary>
    [IsoId("_xPt7h2jNEeiRg5NzP0jkQg")]
    [DisplayName("Technical Address")]
    public partial record TechnicalAddress : UpdateLogPartyRecord1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_pAXiNGjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required TechnicalIdentification2Choice_ Old { get; init; } 
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_pAXiNWjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required TechnicalIdentification2Choice_ New { get; init; } 
        
        
        #nullable disable
        
    }
}
