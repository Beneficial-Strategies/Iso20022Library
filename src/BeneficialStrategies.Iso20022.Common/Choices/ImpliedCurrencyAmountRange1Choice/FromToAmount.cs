// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice
{
    /// <summary>
    /// Range of valid amount values.
    /// </summary>
    [IsoId("_O_mxNZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("From To Amount")]
    [IsoXmlTag("FrToAmt")]
    public record FromToAmount : ImpliedCurrencyAmountRange1Choice_
    {
        /// <summary>
        /// Lower boundary of a range of amount values.
        /// </summary>
        [IsoId("_jw5KoZljEeeE1Ya-LgRsuQ")]
        [DisplayName("From Amount")]
        [IsoXmlTag("FrAmt")]
        public required AmountRangeBoundary1 FromAmount { get; init; }

        /// <summary>
        /// Upper boundary of a range of amount values.
        /// </summary>
        [IsoId("_jw5Ko5ljEeeE1Ya-LgRsuQ")]
        [DisplayName("To Amount")]
        [IsoXmlTag("ToAmt")]
        public required AmountRangeBoundary1 ToAmount { get; init; }
    }
}
