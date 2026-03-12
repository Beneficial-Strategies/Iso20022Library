// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity6Choice
{
    /// <summary>
    /// Original and current value of an asset-back instrument.
    /// </summary>
    [IsoId("_Sotstdp-Ed-ak6NoX_4Aeg_1621426385")]
    [DisplayName("Original And Current Face")]
    public partial record OriginalAndCurrentFace : Quantity6Choice_
    {
        #nullable enable
        
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
        
        
        #nullable disable
        
    }
}
