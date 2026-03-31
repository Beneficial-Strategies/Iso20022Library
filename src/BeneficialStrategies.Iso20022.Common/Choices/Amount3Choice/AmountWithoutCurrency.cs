// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Amount3Choice
{
    /// <summary>
    /// Number of monetary units specified in a currency where the unit of currency is implied by the context.
    /// </summary>
    [IsoId("_750Bh6MgEeCJ6YNENx4h-w_-1970472994")]
    [DisplayName("Amount Without Currency")]
    [IsoXmlTag("AmtWthtCcy")]
    public record AmountWithoutCurrency : Amount3Choice_
    {
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
    }
}
