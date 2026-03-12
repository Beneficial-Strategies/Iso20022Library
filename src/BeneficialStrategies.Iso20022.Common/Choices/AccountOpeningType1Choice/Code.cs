// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountOpeningType1Choice
{
    /// <summary>
    /// Type of account opening instruction expressed as a code.
    /// </summary>
    [IsoId("_3Et5EUzJEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public partial record Code : AccountOpeningType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account to which an account opening request is related, eg, a new account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountOpeningType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
