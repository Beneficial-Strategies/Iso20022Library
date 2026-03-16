// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification256Choice
{
    /// <summary>
    /// Name And Address.
    /// </summary>
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification256Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NmAndAdr")]
        public required NameAndAddress13 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
