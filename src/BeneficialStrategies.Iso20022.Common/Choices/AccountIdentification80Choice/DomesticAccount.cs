// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification80Choice
{
    /// <summary>
    /// Domestic Account.
    /// </summary>
    [DisplayName("Domestic Account")]
    public partial record DomesticAccount : AccountIdentification80Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DmstAcct")]
        public required SimpleIdentificationInformation4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
