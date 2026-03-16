// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification75Choice
{
    /// <summary>
    /// Accounts List.
    /// </summary>
    [DisplayName("Accounts List")]
    public partial record AccountsList : AccountIdentification75Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctsList")]
        public required AccountIdentification75 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
