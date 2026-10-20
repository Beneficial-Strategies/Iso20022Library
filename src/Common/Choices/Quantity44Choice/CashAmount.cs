// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity44Choice
{
    /// <summary>
    /// Cash amount to be transferred.
    /// </summary>
    [IsoId("_ZMtfME3WEeidB49bWZiS0g")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public partial record CashAmount : Quantity44Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Currency")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required ActiveCurrencyCode Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Amount")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Amount")]
        [IsoXmlTag("Amount")]
        [IsoAmount(18, 13)]
        public required decimal Amount
        {
            get => _amount;
            init => _amount = IsoAmountFacets.Check(typeof(CashAmount), nameof(Amount), value);
        }

        private decimal _amount;
    }
}
