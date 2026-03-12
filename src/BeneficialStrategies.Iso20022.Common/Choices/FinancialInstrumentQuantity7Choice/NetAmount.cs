// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity7Choice
{
    /// <summary>
    /// Amount of money remaining after deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[Quantity * Price].
    /// </summary>
    [IsoId("_Rg5JBNp-Ed-ak6NoX_4Aeg_986933490")]
    [DisplayName("Net Amount")]
    public partial record NetAmount : FinancialInstrumentQuantity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Currency")]
        [DisplayName("Active Or Historic Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YYB_9tp-Ed-ak6NoX_4Aeg_-1587763373_Amount")]
        [DisplayName("Active Or Historic Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
