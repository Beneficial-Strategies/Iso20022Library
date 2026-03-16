// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType39Choice
{
    /// <summary>
    /// Modification.
    /// </summary>
    [DisplayName("Modification")]
    public partial record Modification : UpdateType39Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Mod")]
        public required SecuritiesSettlementTransactionDetails57 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
