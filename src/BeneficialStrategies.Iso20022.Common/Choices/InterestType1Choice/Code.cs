// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestType1Choice
{
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_SRnbV9p-Ed-ak6NoX_4Aeg_-822918101")]
    [DisplayName("Code")]
    public partial record Code : InterestType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates which type of interest is applied to a balance left on an account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
