// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_xPt7g2jNEeiRg5NzP0jkQg")]
    [DisplayName("Type")]
    public partial record Type : UpdateLogPartyRecord1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_5Lc0RGjTEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required SystemPartyType1Choice_ Old { get; init; } 
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_5Lc0RWjTEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required SystemPartyType1Choice_ New { get; init; } 
        
        
        #nullable disable
        
    }
}
