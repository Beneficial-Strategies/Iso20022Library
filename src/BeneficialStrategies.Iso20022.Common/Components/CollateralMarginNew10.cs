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
[IsoId("_5AgsRcgoEeuGrNSsxk3B0A")]
[DisplayName("Collateral Margin New")]
public record CollateralMarginNew10
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_5CDkYcgoEeuGrNSsxk3B0A")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_5CDkY8goEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_5CDkZcgoEeuGrNSsxk3B0A")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Set of information specific to counterparties of the reported transaction.
    /// </summary>
    [IsoId("_5CDkZ8goEeuGrNSsxk3B0A")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required Counterparty39 Counterparty { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_5CDkacgoEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Portfolio Identification")]
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; }

    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_5CDka8goEeuGrNSsxk3B0A")]
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; }

    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    [IsoId("_5CDkbcgoEeuGrNSsxk3B0A")]
    [DisplayName("Received Margin Or Collateral")]
    [IsoXmlTag("RcvdMrgnOrColl")]
    public ReceivedMarginOrCollateral4? ReceivedMarginOrCollateral { get; init; }

    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_5CDkb8goEeuGrNSsxk3B0A")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public ReconciliationFlag2? ReconciliationFlag { get; init; }

    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_5CDkccgoEeuGrNSsxk3B0A")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public required ContractModification3 ContractModification { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_5CDkc8goEeuGrNSsxk3B0A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
