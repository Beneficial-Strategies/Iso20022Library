// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a non-equity asset-class and sub-class.
/// </summary>
[IsoId("_b_iE8aaUEeqZmriXpMtonA")]
[DisplayName("Asset Class And Sub Class Identification")]
public record AssetClassAndSubClassIdentification2
{
    /// <summary>
    /// Asset class of non-equity instruments to which the result relates
    /// </summary>
    [IsoId("_cBU0saaUEeqZmriXpMtonA")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public required NonEquityAssetClass1Code AssetClass { get; init; }

    /// <summary>
    /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
    /// </summary>
    [IsoId("_cBU0s6aUEeqZmriXpMtonA")]
    [DisplayName("Derivative Sub Class")]
    [IsoXmlTag("DerivSubClss")]
    public NonEquitySubClass1? DerivativeSubClass { get; init; }

    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_cBU0taaUEeqZmriXpMtonA")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; }
}
