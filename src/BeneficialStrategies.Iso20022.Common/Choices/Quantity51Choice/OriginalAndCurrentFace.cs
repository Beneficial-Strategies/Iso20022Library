// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity51Choice
{
    /// <summary>
    /// Original and current value of an asset-back instrument.
    /// </summary>
    [IsoId("_Lql5cxuyEeyhRdHRjakS2w")]
    [DisplayName("Original And Current Face")]
    public record OriginalAndCurrentFace : Quantity51Choice_
    {
        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
        /// </summary>
        [IsoId("_Sotst9p-Ed-ak6NoX_4Aeg_1262349956")]
        [DisplayName("Face Amount")]
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAndAmount FaceAmount { get; init; }

        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_So3dsNp-Ed-ak6NoX_4Aeg_1277126235")]
        [DisplayName("Amortised Value")]
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAndAmount AmortisedValue { get; init; }
    }
}
