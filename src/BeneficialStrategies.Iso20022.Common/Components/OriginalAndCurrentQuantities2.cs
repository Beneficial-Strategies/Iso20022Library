// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed face amount and amortised value.
/// </summary>
[IsoId("_QzvvKdp-Ed-ak6NoX_4Aeg_-1494252441")]
[DisplayName("Original And Current Quantities")]
public partial record OriginalAndCurrentQuantities2
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
