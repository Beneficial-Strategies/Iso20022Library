// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeCounterpartyRelationship1Choice
{
    /// <summary>
    /// Classification of the party relationship via a pre-determined code list.
    /// </summary>
    [IsoId("_uWGXECb_Ee2BYL6XeAmCWw")]
    [DisplayName("Code")]
    public partial record Code : TradeCounterpartyRelationship1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external the party relationship type code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPartyRelationshipType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
