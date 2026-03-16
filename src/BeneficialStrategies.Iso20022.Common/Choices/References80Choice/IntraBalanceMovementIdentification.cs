// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <summary>
    /// Intra Balance Movement Identification.
    /// </summary>
    [DisplayName("Intra Balance Movement Identification")]
    public partial record IntraBalanceMovementIdentification : References80Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IntraBalMvmntId")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
