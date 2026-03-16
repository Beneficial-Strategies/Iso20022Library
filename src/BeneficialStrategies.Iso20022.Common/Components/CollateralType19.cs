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
[IsoId("__pYAga5nEeuo-IflVgGqiA")]
[DisplayName("Collateral Type")]
public record CollateralType19
{
    /// <summary>
    /// Provides the details of the security pledged as collateral.
    /// </summary>
    [IsoId("__431Ea5nEeuo-IflVgGqiA")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public SecurityReuseData1? Security { get; init; }

    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency and the average interest rate received.
    /// </summary>
    [IsoId("__431E65nEeuo-IflVgGqiA")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public CashReuseData1? Cash { get; init; }
}
