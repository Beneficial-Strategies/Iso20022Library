// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency Data Report21.
/// </summary>
[IsoId("_tFpIAW8mEe6_0L6gLGEkbA")]
[DisplayName("Transparency Data Report21")]
public record TransparencyDataReport21
{
    /// <summary>
    /// Technical Record Identification.
    /// </summary>
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    public Max35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required ISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Full Name.
    /// </summary>
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    public Max350Text? FullName { get; init; }

    /// <summary>
    /// Trading Venue.
    /// </summary>
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public MICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Reporting Date.
    /// </summary>
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    public ISODate? ReportingDate { get; init; }

    /// <summary>
    /// Maturity Date.
    /// </summary>
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public ISODate? MaturityDate { get; init; }

    /// <summary>
    /// Financial Instrument Classification.
    /// </summary>
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public required NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; }

    /// <summary>
    /// Underlying Instrument Asset Class.
    /// </summary>
    [DisplayName("Underlying Instrument Asset Class")]
    [IsoXmlTag("UndrlygInstrmAsstClss")]
    public ExternalProductType1Code? UnderlyingInstrumentAssetClass { get; init; }

    /// <summary>
    /// Derivative Contract Type.
    /// </summary>
    [DisplayName("Derivative Contract Type")]
    [IsoXmlTag("DerivCtrctTp")]
    public FinancialInstrumentContractType1Code? DerivativeContractType { get; init; }

    /// <summary>
    /// Bond.
    /// </summary>
    [DisplayName("Bond")]
    [IsoXmlTag("Bd")]
    public DebtInstrument5? Bond { get; init; }

    /// <summary>
    /// Emission Allowance Type.
    /// </summary>
    [DisplayName("Emission Allowance Type")]
    [IsoXmlTag("EmssnAllwncTp")]
    public ExternalEmissionAllowanceSubProductType1Code? EmissionAllowanceType { get; init; }

    /// <summary>
    /// Derivative.
    /// </summary>
    [DisplayName("Derivative")]
    [IsoXmlTag("Deriv")]
    public Derivative3Choice_? Derivative { get; init; }
}
