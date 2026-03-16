// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Investment2Choice
{
    /// <summary>
    /// Central Bank Deposit.
    /// </summary>
    [DisplayName("Central Bank Deposit")]
    public partial record CentralBankDeposit : Investment2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CntrlBkDpst")]
        public required Deposit1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
