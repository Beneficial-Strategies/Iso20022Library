// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod5Choice
{
    /// <summary>
    /// Credit.
    /// </summary>
    [DisplayName("Credit")]
    public partial record Credit : SettlementMethod5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cdt")]
        public required CreditTransferTransaction59 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
