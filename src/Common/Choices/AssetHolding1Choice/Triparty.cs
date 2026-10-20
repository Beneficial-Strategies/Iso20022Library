// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice
{
    /// <summary>
    /// Mark-to-market pre-haircut value of triparty collateral.
    /// </summary>
    [IsoId("_0kAaQK_6EeaE9YROwd69hA")]
    [DisplayName("Triparty")]
    [IsoXmlTag("Trpty")]
    public partial record Triparty : AssetHolding1Choice_
    {
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Currency")]
        [DisplayName("Active Currency And Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required ActiveCurrencyCode Currency { get; init; }

        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Amount")]
        [DisplayName("Active Currency And Amount _ Amount")]
        [IsoXmlTag("Amount")]
        [IsoAmount(18, 5)]
        public required decimal Amount
        {
            get => _amount;
            init => _amount = IsoAmountFacets.Check(typeof(Triparty), nameof(Amount), value);
        }

        private decimal _amount;
    }
}
