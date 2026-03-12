// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <summary>
    /// Specifies a frequency in terms of a specified period type.
    /// </summary>
    [IsoId("_seR6MWk2Eeanu6HLe77Rkg")]
    [DisplayName("Type")]
    public partial record Type : Frequency36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required Frequency6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
