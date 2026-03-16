// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification80Choice
{
    /// <summary>
    /// BBAN.
    /// </summary>
    [DisplayName("BBAN")]
    public partial record BBAN : AccountIdentification80Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BBAN")]
        public required IsoBBANIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
