// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity30Choice
{
    /// <summary>
    /// Indicates that quantity is expressed as a nominal value.
    /// </summary>
    [IsoId("_zSz2pf9jEea3W_f2lS_aiw")]
    [DisplayName("Nominal Value")]
    public partial record NominalValue : FinancialInstrumentQuantity30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_JG0mceaqEeW1iL_FRZt8bg_Currency")]
        [DisplayName("Implied Currency And 20 Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_JG0mceaqEeW1iL_FRZt8bg_Amount")]
        [DisplayName("Implied Currency And 20 Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
