// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingContract4Choice
{
    /// <summary>
    /// Loan.
    /// </summary>
    [DisplayName("Loan")]
    public partial record Loan : UnderlyingContract4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Ln")]
        public required LoanContract4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
