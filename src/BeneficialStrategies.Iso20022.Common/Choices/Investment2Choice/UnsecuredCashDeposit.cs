// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Investment2Choice
{
    /// <summary>
    /// Unsecured Cash Deposit.
    /// </summary>
    [DisplayName("Unsecured Cash Deposit")]
    public partial record UnsecuredCashDeposit : Investment2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UscrdCshDpst")]
        public required Deposit1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
