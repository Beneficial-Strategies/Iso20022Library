// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationType1Choice
{
    /// <summary>
    /// Proprietary.
    /// </summary>
    [DisplayName("Proprietary")]
    public partial record Proprietary : InvestigationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
