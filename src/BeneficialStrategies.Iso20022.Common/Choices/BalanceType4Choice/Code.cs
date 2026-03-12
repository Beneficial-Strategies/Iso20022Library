// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceType4Choice
{
    /// <summary>
    /// Specifies the code for the type of a balance, eg, opening booked balance.
    /// </summary>
    [IsoId("_RcRuwdp-Ed-ak6NoX_4Aeg_-1171282174")]
    [DisplayName("Code")]
    public partial record Code : BalanceType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the balance, eg, opening balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType11Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
