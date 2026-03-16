// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrPercentage1Choice
{
    /// <summary>
    /// Details related to a defined monetary amount.
    /// </summary>
    [IsoId("_986x53ltEeG7BsjMvd1mEw_-1070364431")]
    [DisplayName("Defined Amount")]
    public record DefinedAmount : AmountOrPercentage1Choice_
    {
        /// <summary>
        /// Variation amount and currency.
        /// </summary>
        [IsoId("_945NhHltEeG7BsjMvd1mEw_1236951493")]
        [DisplayName("Variation Amount")]
        [IsoXmlTag("VartnAmt")]
        public required ActiveCurrencyAndAmount VariationAmount { get; init; }

        /// <summary>
        /// Calculated undertaking available balance amount resulting from the application of the variation amount.
        /// </summary>
        [IsoId("_95C-gHltEeG7BsjMvd1mEw_1336485232")]
        [DisplayName("Balance Amount")]
        [IsoXmlTag("BalAmt")]
        public ActiveCurrencyAndAmount? BalanceAmount { get; init; }
    }
}
