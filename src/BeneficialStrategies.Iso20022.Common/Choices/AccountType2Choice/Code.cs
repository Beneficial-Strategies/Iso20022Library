// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountType2Choice
{
    /// <summary>
    /// Type of account expressed as a code.
    /// </summary>
    [IsoId("_dPO1ESC7EeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public partial record Code : AccountType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the account type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundCashAccount4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
