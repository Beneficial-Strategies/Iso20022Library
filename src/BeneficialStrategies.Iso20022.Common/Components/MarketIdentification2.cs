// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about market identification and market type.
/// </summary>
[IsoId("_URxVOdp-Ed-ak6NoX_4Aeg_-1818595308")]
[DisplayName("Market Identification")]
public record MarketIdentification2
{
    /// <summary>
    /// Specifies the type of market.
    /// </summary>
    [IsoId("_URxVOtp-Ed-ak6NoX_4Aeg_-1367916516")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarketTypeFormat1Choice_ Type { get; init; }

    /// <summary>
    /// Identifies the market.
    /// </summary>
    [IsoId("_URxVO9p-Ed-ak6NoX_4Aeg_-870756545")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public MarketIdentification1Choice_? Identification { get; init; }
}
