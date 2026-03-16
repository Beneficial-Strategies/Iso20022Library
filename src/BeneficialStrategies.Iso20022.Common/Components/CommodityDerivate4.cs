// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details for an commodity derivatives.
/// </summary>
[IsoId("_zeGjUWlHEeaLAKoEUNsD9g")]
[DisplayName("Commodity Derivate")]
public record CommodityDerivate4
{
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    [IsoId("_znHVYWlHEeaLAKoEUNsD9g")]
    [DisplayName("Class Specific")]
    [IsoXmlTag("ClssSpcfc")]
    public CommodityDerivate2Choice_? ClassSpecific { get; init; }

    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_znHVY2lHEeaLAKoEUNsD9g")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; }
}
