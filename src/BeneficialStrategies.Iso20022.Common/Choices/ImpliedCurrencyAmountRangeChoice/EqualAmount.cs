// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice
{
    /// <summary>
    /// Exact value an amount must match to be considered valid.
    /// </summary>
    [IsoId("_PVH1Adp-Ed-ak6NoX_4Aeg_-1174057054")]
    [DisplayName("Equal Amount")]
    public partial record EqualAmount : ImpliedCurrencyAmountRangeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YXbjBNp-Ed-ak6NoX_4Aeg_-1934687468_Currency")]
        [DisplayName("Implied Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YXbjBNp-Ed-ak6NoX_4Aeg_-1934687468_Amount")]
        [DisplayName("Implied Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
