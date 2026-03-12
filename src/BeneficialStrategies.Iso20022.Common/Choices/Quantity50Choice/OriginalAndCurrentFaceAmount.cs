// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity50Choice
{
    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_LU1r4RuyEeyhRdHRjakS2w")]
    [DisplayName("Original And Current Face Amount")]
    public partial record OriginalAndCurrentFaceAmount : Quantity50Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_MLOD4zq5EeWQ1Y7f8kds2A")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
        /// </summary>
        [IsoId("_MLOD5Tq5EeWQ1Y7f8kds2A")]
        [DisplayName("Face Amount")]
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAndAmount FaceAmount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_MLOD7Tq5EeWQ1Y7f8kds2A")]
        [DisplayName("Amortised Value")]
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        
        
        #nullable disable
        
    }
}
