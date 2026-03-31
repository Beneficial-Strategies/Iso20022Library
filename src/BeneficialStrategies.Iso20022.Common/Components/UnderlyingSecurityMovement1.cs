// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the underlying securities movement.
/// </summary>
[IsoId("_UIO-sNp-Ed-ak6NoX_4Aeg_-697458395")]
[DisplayName("Underlying Security Movement")]
public record UnderlyingSecurityMovement1
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIO-sdp-Ed-ak6NoX_4Aeg_-326202017")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_UIO-stp-Ed-ak6NoX_4Aeg_-310505043")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about the debited/credited securities account.
    /// </summary>
    [IsoId("_UIO-s9p-Ed-ak6NoX_4Aeg_692438850")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount8> AccountDetails { get; init; } = [];
}
