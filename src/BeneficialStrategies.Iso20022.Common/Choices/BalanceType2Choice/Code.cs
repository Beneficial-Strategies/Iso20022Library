// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceType2Choice
{
    /// <summary>
    /// Specifies the code for the type of a balance, eg, opening booked balance.
    /// </summary>
    [IsoId("_RcH9w9p-Ed-ak6NoX_4Aeg_1127274794")]
    [DisplayName("Code")]
    public partial record Code : BalanceType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the balance, eg, opening balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
