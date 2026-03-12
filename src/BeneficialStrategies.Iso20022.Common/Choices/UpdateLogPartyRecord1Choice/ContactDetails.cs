// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the contact details of the party.
    /// </summary>
    [IsoId("_xPt7gWjNEeiRg5NzP0jkQg")]
    [DisplayName("Contact Details")]
    public partial record ContactDetails : UpdateLogPartyRecord1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Old value before change
        /// </summary>
        [IsoId("_YBkCRGjTEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required Contact5 Old { get; init; } 
        
        /// <summary>
        /// New value after change
        /// </summary>
        [IsoId("_YBkCRWjTEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required Contact5 New { get; init; } 
        
        
        #nullable disable
        
    }
}
