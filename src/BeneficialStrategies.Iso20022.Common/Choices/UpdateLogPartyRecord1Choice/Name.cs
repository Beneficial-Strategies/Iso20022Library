// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_xPt7iGjNEeiRg5NzP0jkQg")]
    [DisplayName("Name")]
    public partial record Name : UpdateLogPartyRecord1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_zOmJYWjVEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required PartyName4 Old { get; init; } 
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_zOmJYmjVEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required PartyName4 New { get; init; } 
        
        
        #nullable disable
        
    }
}
