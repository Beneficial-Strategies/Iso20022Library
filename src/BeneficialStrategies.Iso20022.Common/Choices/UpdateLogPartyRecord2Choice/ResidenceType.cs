// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord2Choice
{
    /// <summary>
    /// Residence Type.
    /// </summary>
    [DisplayName("Residence Type")]
    public partial record ResidenceType : UpdateLogPartyRecord2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ResTp")]
        public required UpdateLogResidenceType1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
