// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation1Choice
{
    /// <summary>
    /// Identifies internal party.
    /// </summary>
    [IsoId("_W53_AgkhEeWGouz230Xp5Q")]
    [DisplayName("Internal")]
    public partial record Internal : PersonOrOrganisation1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role as an internal party in the transaction.
        /// </summary>
        [IsoXmlTag("Intl")]
        public required InternalPartyRole1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
