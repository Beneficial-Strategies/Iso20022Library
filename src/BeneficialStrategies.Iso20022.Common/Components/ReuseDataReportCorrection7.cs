// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
[IsoId("_76wJUa4bEemB_csI4yyKLA")]
[DisplayName("Reuse Data Report Correction")]
public record ReuseDataReportCorrection7
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_7-7esa4bEemB_csI4yyKLA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Date and time of submission of the report to the entitled receiver.
    /// </summary>
    [IsoId("_7-7es64bEemB_csI4yyKLA")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_7-7eta4bEemB_csI4yyKLA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData46 CounterpartyData { get; init; }

    /// <summary>
    /// Provides the details of the security or cash pledged as collateral.
    /// </summary>
    [IsoId("_7-7et64bEemB_csI4yyKLA")]
    [DisplayName("Collateral Component")]
    [IsoXmlTag("CollCmpnt")]
    public ValueList<CollateralType12> CollateralComponent { get; init; } = [];

    // ID for the above is _7-7et64bEemB_csI4yyKLA

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_7-7eua4bEemB_csI4yyKLA")]
    [DisplayName("Event Day")]
    [IsoXmlTag("EvtDay")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDay { get; init; }

    /// <summary>
    /// Information on funding sources used to finance margin loans.
    /// </summary>
    [IsoId("_7-7eu64bEemB_csI4yyKLA")]
    [DisplayName("Funding Source")]
    [IsoXmlTag("FndgSrc")]
    public ValueList<FundingSource1> FundingSource { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_7-7eva4bEemB_csI4yyKLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
