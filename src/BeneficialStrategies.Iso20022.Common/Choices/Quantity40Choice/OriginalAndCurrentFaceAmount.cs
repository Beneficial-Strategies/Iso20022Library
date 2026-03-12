// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity40Choice
{
    /// <summary>
    /// Face amount and amortised value of security.
    /// </summary>
    [IsoId("_NwxZHpp3EeWLs7cvLxlyAg")]
    [DisplayName("Original And Current Face Amount")]
    public partial record OriginalAndCurrentFaceAmount : Quantity40Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
        /// </summary>
        [IsoId("_WsJF4dp-Ed-ak6NoX_4Aeg_-30588770")]
        [DisplayName("Face Amount")]
        [IsoXmlTag("FaceAmt")]
        public required RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_WsJF4tp-Ed-ak6NoX_4Aeg_1660909971")]
        [DisplayName("Amortised Value")]
        [IsoXmlTag("AmtsdVal")]
        public required RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        
        
        #nullable disable
        
    }
}
