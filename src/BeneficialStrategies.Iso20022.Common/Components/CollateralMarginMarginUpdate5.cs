// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the collateral margin data.
/// </summary>
[IsoId("_h3QwYcg2EeuGrNSsxk3B0A")]
[DisplayName("Collateral Margin Margin Update")]
public record CollateralMarginMarginUpdate5
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_h5Ac0cg2EeuGrNSsxk3B0A")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_h5Ac08g2EeuGrNSsxk3B0A")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; }

    /// <summary>
    /// Date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_h5Ac1cg2EeuGrNSsxk3B0A")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Data specific to counterparties of the reported transaction.
    /// </summary>
    [IsoId("_h5Ac18g2EeuGrNSsxk3B0A")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public Counterparty39? Counterparty { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_h5Ac2cg2EeuGrNSsxk3B0A")]
    [DisplayName("Collateral Portfolio Identification")]
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; }

    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_h5Ac28g2EeuGrNSsxk3B0A")]
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; }

    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    [IsoId("_h5Ac3cg2EeuGrNSsxk3B0A")]
    [DisplayName("Received Margin Or Collateral")]
    [IsoXmlTag("RcvdMrgnOrColl")]
    public ReceivedMarginOrCollateral4? ReceivedMarginOrCollateral { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_h5Ac38g2EeuGrNSsxk3B0A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
