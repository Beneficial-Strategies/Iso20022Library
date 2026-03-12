// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party29Choice
{
    /// <summary>
    /// Identification of a person or an organisation.
    /// </summary>
    [IsoId("_5wjW9UyhEeWw591U1lOHyQ")]
    [DisplayName("Organisation Identification")]
    public partial record OrganisationIdentification : Party29Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a party.
        /// </summary>
        [IsoId("_lTBtZ0yiEeWw591U1lOHyQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public Party1? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}
