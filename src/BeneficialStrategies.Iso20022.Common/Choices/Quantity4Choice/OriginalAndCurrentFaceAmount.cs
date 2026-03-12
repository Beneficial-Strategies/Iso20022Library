// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity4Choice
{
    /// <summary>
    /// Signed face amount and amortised value of security.
    /// </summary>
    [IsoId("_Qz45E9p-Ed-ak6NoX_4Aeg_-1207963739")]
    [DisplayName("Original And Current Face Amount")]
    public partial record OriginalAndCurrentFaceAmount : Quantity4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_QzvvKtp-Ed-ak6NoX_4Aeg_1141154635")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
        /// </summary>
        [IsoId("_QzvvK9p-Ed-ak6NoX_4Aeg_-1124847199")]
        [DisplayName("Face Amount")]
        [IsoXmlTag("FaceAmt")]
        public required ImpliedCurrencyAndAmount FaceAmount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_QzvvLNp-Ed-ak6NoX_4Aeg_-1124846922")]
        [DisplayName("Amortised Value")]
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        
        
        #nullable disable
        
    }
}
