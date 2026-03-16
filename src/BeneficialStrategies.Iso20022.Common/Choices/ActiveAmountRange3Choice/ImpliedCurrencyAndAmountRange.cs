// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ActiveAmountRange3Choice
{
    /// <summary>
    /// Expresses an amount or an amount range with an explicit debit/credit indicator and where the currency is implied.
    /// </summary>
    [IsoId("_OvM9s5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Implied Currency And Amount Range")]
    public record ImpliedCurrencyAndAmountRange : ActiveAmountRange3Choice_
    {
        /// <summary>
        /// A specified amount or amount range.
        /// </summary>
        [IsoId("_O3sLUZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; }

        /// <summary>
        /// Indicates whether the amount is a credited or debited amount.
        /// </summary>
        [IsoId("_O3sLU5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; }
    }
}
