// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConfirmationType1Choice
{
    /// <summary>
    /// Confirmation type expressed as a code.
    /// </summary>
    [IsoId("_tv-sYUzLEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public partial record Code : ConfirmationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Refer to an account management instruction ie, either an account opening instruction or an account modification instruction or a get account details message.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountManagementType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
