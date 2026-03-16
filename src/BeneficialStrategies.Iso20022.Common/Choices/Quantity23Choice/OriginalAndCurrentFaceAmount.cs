// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity23Choice
{
    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_cfsEX5KQEeWHWpTQn1FFVg")]
    [DisplayName("Original And Current Face Amount")]
    public record OriginalAndCurrentFaceAmount : Quantity23Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_cfsEZ5KQEeWHWpTQn1FFVg")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
        /// </summary>
        [IsoId("_cfsEaZKQEeWHWpTQn1FFVg")]
        [DisplayName("Face Amount")]
        [IsoXmlTag("FaceAmt")]
        public required RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; }

        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_cfsEcZKQEeWHWpTQn1FFVg")]
        [DisplayName("Amortised Value")]
        [IsoXmlTag("AmtsdVal")]
        public required RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; }
    }
}
