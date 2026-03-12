// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountStatus1Choice
{
    /// <summary>
    /// Status of the account expressed as a code.
    /// </summary>
    [IsoId("_Dsx6ACF1EeW9XJWqfgXIIA")]
    [DisplayName("Code")]
    public partial record Code : AccountStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
