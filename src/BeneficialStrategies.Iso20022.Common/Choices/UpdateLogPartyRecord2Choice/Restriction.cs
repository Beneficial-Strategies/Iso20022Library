// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord2Choice
{
    /// <summary>
    /// Restriction.
    /// </summary>
    [DisplayName("Restriction")]
    public partial record Restriction : UpdateLogPartyRecord2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rstrctn")]
        public required UpdateLogRestriction1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
