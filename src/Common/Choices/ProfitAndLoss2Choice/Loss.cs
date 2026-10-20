// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProfitAndLoss2Choice
{
    /// <summary>
    /// Value of the negative amount.
    /// </summary>
    [IsoId("_Nd_nI2YDEeaJx-BUPcSWQA")]
    [DisplayName("Loss")]
    [IsoXmlTag("Loss")]
    public partial record Loss : ProfitAndLoss2Choice_
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
            init => _amount = IsoAmountFacets.Check(typeof(Loss), nameof(Amount), value);
        }

        private decimal _amount;
    }
}
