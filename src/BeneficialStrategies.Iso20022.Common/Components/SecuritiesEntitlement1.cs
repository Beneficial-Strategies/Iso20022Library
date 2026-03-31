// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides entitlement information.
/// </summary>
[IsoId("_UJRgh9p-Ed-ak6NoX_4Aeg_1912782907")]
[DisplayName("Securities Entitlement")]
public record SecuritiesEntitlement1
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UJRgiNp-Ed-ak6NoX_4Aeg_-1841926439")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_UJbRgNp-Ed-ak6NoX_4Aeg_-1548244376")]
    [DisplayName("Entitled Securities Quantity")]
    [IsoXmlTag("EntitldSctiesQty")]
    public required UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; init; }
}
