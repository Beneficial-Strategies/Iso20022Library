// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus6Choice
{
    /// <summary>
    /// Rejected Modification.
    /// </summary>
    [DisplayName("Rejected Modification")]
    public partial record RejectedModification : InvestigationStatus6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RjctdMod")]
        public required ModificationStatusReason1Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
