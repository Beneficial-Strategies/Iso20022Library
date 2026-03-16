// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification78Choice
{
    /// <summary>
    /// Accounts List And Balance Details.
    /// </summary>
    [DisplayName("Accounts List And Balance Details")]
    public partial record AccountsListAndBalanceDetails : AccountIdentification78Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctsListAndBalDtls")]
        public required AccountAndBalance65 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
