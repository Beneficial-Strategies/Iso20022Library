// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount7Choice
{
    /// <summary>
    /// Cash amount to be instructed.
    /// </summary>
    [IsoId("_pizbYzi7Eeydid5dcNPKvg")]
    [DisplayName("Instructed Amount")]
    public partial record InstructedAmount : SecuritiesQuantityOrAmount7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WOVvkNp-Ed-ak6NoX_4Aeg_-1267706960_Currency")]
        [DisplayName("Restricted FIN Active Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_WOVvkNp-Ed-ak6NoX_4Aeg_-1267706960_Amount")]
        [DisplayName("Restricted FIN Active Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
