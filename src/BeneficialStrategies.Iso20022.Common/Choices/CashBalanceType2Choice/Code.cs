// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashBalanceType2Choice
{
    /// <summary>
    /// Cash balance expressed in a coded form.
    /// </summary>
    [IsoId("_lRQiseFWEeWIA4E9cYSxxQ")]
    [DisplayName("Code")]
    public partial record Code : CashBalanceType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
