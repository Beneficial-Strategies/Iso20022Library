// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reversible1Choice
{
    /// <summary>
    /// Closing of the securities lending contract is identified using a code.
    /// </summary>
    [IsoId("_AYXSINokEeC60axPepSq7g_-1292928069")]
    [DisplayName("Code")]
    public partial record Code : Reversible1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reversible1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
