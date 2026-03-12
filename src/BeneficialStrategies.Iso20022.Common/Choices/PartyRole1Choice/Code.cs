// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyRole1Choice
{
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_Q937gtp-Ed-ak6NoX_4Aeg_955968594")]
    [DisplayName("Code")]
    public partial record Code : PartyRole1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of party involved in the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PartyType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
