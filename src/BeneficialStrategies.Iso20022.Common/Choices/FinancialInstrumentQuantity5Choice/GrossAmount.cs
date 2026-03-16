// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity5Choice
{
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_Soaxxdp-Ed-ak6NoX_4Aeg_1036647225")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public record GrossAmount : FinancialInstrumentQuantity5Choice_
    {
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
    }
}
