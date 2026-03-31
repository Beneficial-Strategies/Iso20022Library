// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Asset class specific details of a derivative.
/// </summary>
[IsoId("_Hx9E0cnYEeWpf-ImB_F2gQ")]
[DisplayName("Asset Class Attributes")]
public record AssetClassAttributes1
{
    /// <summary>
    /// Asset class is a non-financial instrument of type interest rate.
    /// </summary>
    [IsoId("_IO1OE8nYEeWpf-ImB_F2gQ")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public required DerivativeInterest2 Interest { get; init; }

    /// <summary>
    /// Asset class is a non-financial instrument of type foreign exchange.
    /// </summary>
    [IsoId("_IO1OFcnYEeWpf-ImB_F2gQ")]
    [DisplayName("Foreign Exchange")]
    [IsoXmlTag("FX")]
    public required DerivativeForeignExchange2 ForeignExchange { get; init; }
}
