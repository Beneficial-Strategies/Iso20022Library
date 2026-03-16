// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria2Choice
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    public partial record Account : SearchCriteria2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Acct")]
        public required AccountAndParties3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
