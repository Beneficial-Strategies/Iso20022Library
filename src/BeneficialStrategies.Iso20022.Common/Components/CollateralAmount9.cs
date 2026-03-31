// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities collateral position valuation amounts.
/// </summary>
[IsoId("__gn0GPSgEeicy5Zn42b9bg")]
[DisplayName("Collateral Amount")]
public record CollateralAmount9
{
    /// <summary>
    /// Actual market value post haircut expressed in the collateral currency.
    /// </summary>
    [IsoId("__gn0H_SgEeicy5Zn42b9bg")]
    [DisplayName("Actual Market Value Post Haircut")]
    [IsoXmlTag("ActlMktValPstHrcut")]
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostHaircut { get; init; }

    /// <summary>
    /// Actual market value before haircut expressed in the collateral currency.
    /// </summary>
    [IsoId("__gn0HfSgEeicy5Zn42b9bg")]
    [DisplayName("Actual Market Value Before Haircut")]
    [IsoXmlTag("ActlMktValBfrHrcut")]
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeHaircut { get; init; }

    /// <summary>
    /// Amount of the exposure/collateral in the exposure/collateral currency.
    /// </summary>
    [IsoId("__gn0HvSgEeicy5Zn42b9bg")]
    [DisplayName("Exposure Collateral In Transaction Currency")]
    [IsoXmlTag("XpsrCollInTxCcy")]
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInTransactionCurrency { get; init; }

    /// <summary>
    /// Amount of the exposure/collateral in the reporting currency.
    /// </summary>
    [IsoId("__gn0G_SgEeicy5Zn42b9bg")]
    [DisplayName("Exposure Collateral In Reporting Currency")]
    [IsoXmlTag("XpsrCollInRptgCcy")]
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInReportingCurrency { get; init; }

    /// <summary>
    /// Actual market value post haircut expressed in the transaction currency.
    /// </summary>
    [IsoId("__gn0IPSgEeicy5Zn42b9bg")]
    [DisplayName("Market Value Amount Post Haircut")]
    [IsoXmlTag("MktValAmtPstHrcut")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostHaircut { get; init; }

    /// <summary>
    /// Actual market value before haircut expressed in the transaction currency.
    /// </summary>
    [IsoId("__gn0HPSgEeicy5Zn42b9bg")]
    [DisplayName("Market Value Amount Before Haircut")]
    [IsoXmlTag("MktValAmtBfrHrcut")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeHaircut { get; init; }
}
