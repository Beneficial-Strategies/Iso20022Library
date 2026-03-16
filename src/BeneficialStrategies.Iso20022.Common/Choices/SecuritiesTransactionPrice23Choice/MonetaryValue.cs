// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice23Choice
{
    /// <summary>
    /// Monetary Value.
    /// </summary>
    [DisplayName("Monetary Value")]
    public partial record MonetaryValue : SecuritiesTransactionPrice23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MntryVal")]
        public required AmountAndDirection106 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
