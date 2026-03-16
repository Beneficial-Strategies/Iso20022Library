// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security or cash pledged as collateral.
/// </summary>
[IsoId("_MAdVYcpnEem6kd3Y9uIDqg")]
[DisplayName("Collateral Type")]
public record CollateralType12
{
    /// <summary>
    /// Provides the details of the security pledged as collateral.
    /// </summary>
    [IsoId("_MEoqwcpnEem6kd3Y9uIDqg")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public ValueList<SecurityReuseData1> Security { get; init; } = [];

    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency and the average interest rate received.
    /// </summary>
    [IsoId("_MEoqw8pnEem6kd3Y9uIDqg")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public ValueList<CashReuseData1> Cash { get; init; } = [];
}
