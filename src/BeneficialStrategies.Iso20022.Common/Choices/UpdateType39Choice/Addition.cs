// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType39Choice
{
    /// <summary>
    /// Addition.
    /// </summary>
    [DisplayName("Addition")]
    public partial record Addition : UpdateType39Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Addtn")]
        public required SecuritiesSettlementTransactionDetails56 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
