// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData2Choice
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    public partial record Account : UnderlyingData2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Acct")]
        public required CashAccount40 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
