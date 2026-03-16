// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Triparty Collateral And Amount1.
/// </summary>
[IsoId("_HHKmAChKEe2H2s7qerne1w")]
[DisplayName("Triparty Collateral And Amount1")]
public record TripartyCollateralAndAmount1
{
    /// <summary>
    /// Collateral Type.
    /// </summary>
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType22Choice_ CollateralType { get; init; }

    /// <summary>
    /// Triparty.
    /// </summary>
    [DisplayName("Triparty")]
    [IsoXmlTag("Trpty")]
    public required ActiveCurrencyAndAmount Triparty { get; init; }
}
