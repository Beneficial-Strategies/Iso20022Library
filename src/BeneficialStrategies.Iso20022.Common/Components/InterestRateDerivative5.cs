// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the interest rate derivative specific elements for interest rate derivatives as defined in the local regulation.
/// </summary>
[IsoId("_xJiqQWlIEeaLAKoEUNsD9g")]
[DisplayName("Interest Rate Derivative")]
public record InterestRateDerivative5
{
    /// <summary>
    /// Specific details on the underlying type of the interest rate derivative.
    /// </summary>
    [IsoId("_xSfx8WlIEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Type")]
    [IsoXmlTag("UndrlygTp")]
    public required InterestRateDerivative2Choice_ UnderlyingType { get; init; }

    /// <summary>
    /// Populated when the underlying type is a bond or a bond future. Details the issuer and maturity date of the bond.
    /// </summary>
    [IsoId("_xSfx82lIEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Bond")]
    [IsoXmlTag("UndrlygBd")]
    public BondDerivative2? UnderlyingBond { get; init; }

    /// <summary>
    /// Notional currency of a swaption.
    /// </summary>
    [IsoId("_xSfx9WlIEeaLAKoEUNsD9g")]
    [DisplayName("Swaption Notional Currency")]
    [IsoXmlTag("SwptnNtnlCcy")]
    public ActiveCurrencyCode? SwaptionNotionalCurrency { get; init; }

    /// <summary>
    /// Maturity date of the underlying swap, populated for swaptions, futures on swaps and forwards on a swap only.
    /// </summary>
    [IsoId("_xSfx92lIEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Swap Maturity Date")]
    [IsoXmlTag("UndrlygSwpMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnderlyingSwapMaturityDate { get; init; }

    /// <summary>
    /// Populated to define the inflation index.
    /// </summary>
    [IsoId("_xSfx-WlIEeaLAKoEUNsD9g")]
    [DisplayName("Inflation Index")]
    [IsoXmlTag("InfltnIndx")]
    public InflationIndex1Choice_? InflationIndex { get; init; }

    /// <summary>
    /// Provides the interest rate against a reference rate and term in number of days, weeks, months or years.
    /// </summary>
    [IsoId("_xSfx-2lIEeaLAKoEUNsD9g")]
    [DisplayName("Interest Rate Reference")]
    [IsoXmlTag("IntrstRateRef")]
    public required FloatingInterestRate8 InterestRateReference { get; init; }
}
