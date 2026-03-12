// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of security formats.
/// </summary>
[IsoId("_Q0of9Np-Ed-ak6NoX_4Aeg_-761434658")]
[DisplayName("Signed Quantity Format")]
public partial record SignedQuantityFormat1
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_Q0of9dp-Ed-ak6NoX_4Aeg_1211863483")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public required ShortLong1Code ShortLongPosition { get; init; } 
    
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [IsoId("_Q0of9tp-Ed-ak6NoX_4Aeg_1680090925")]
    [DisplayName("Quantity Choice")]
    [IsoXmlTag("QtyChc")]
    public required Quantity2Choice_ QuantityChoice { get; init; } 
    
    
    #nullable disable
    
}
