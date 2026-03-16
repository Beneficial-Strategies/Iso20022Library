// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionPrice3Choice
{
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_tp_6RFkyEeGeoaLUQk__nA_-1722100526")]
    [DisplayName("Deal Price")]
    public record DealPrice : TransactionPrice3Choice_
    {
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_QfxqSNp-Ed-ak6NoX_4Aeg_-109280990")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required YieldedOrValueType1Choice_ Type { get; init; }

        /// <summary>
        /// Value of the price, for example, as a currency and value.
        /// </summary>
        [IsoId("_QfxqSdp-Ed-ak6NoX_4Aeg_-371294350")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required PriceRateOrAmountChoice_ Value { get; init; }
    }
}
