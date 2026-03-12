// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice
{
    /// <summary>
    /// Value that an amount must not match to be considered valid.
    /// </summary>
    [IsoId("_PVH1Atp-Ed-ak6NoX_4Aeg_-1093710164")]
    [DisplayName("Not Equal Amount")]
    public partial record NotEqualAmount : ImpliedCurrencyAmountRangeChoice_
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
