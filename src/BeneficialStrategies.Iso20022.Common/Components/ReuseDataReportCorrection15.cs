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
[IsoId("_S05rFcK9EeuCIrYISEfoUg")]
[DisplayName("Reuse Data Report Correction")]
public record ReuseDataReportCorrection15
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_S2WckcK9EeuCIrYISEfoUg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_S2Wck8K9EeuCIrYISEfoUg")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required CounterpartyData87 Counterparty { get; init; }

    /// <summary>
    /// Provides the details of the security or cash pledged as collateral.
    /// </summary>
    [IsoId("_S2WclcK9EeuCIrYISEfoUg")]
    [DisplayName("Collateral Component")]
    [IsoXmlTag("CollCmpnt")]
    public ValueList<CollateralType19> CollateralComponent { get; init; } = [];

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_S2Wcl8K9EeuCIrYISEfoUg")]
    [DisplayName("Event Day")]
    [IsoXmlTag("EvtDay")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDay { get; init; }

    /// <summary>
    /// Date and time of submission of the report to the entitled receiver.
    /// </summary>
    [IsoId("_S2WcmcK9EeuCIrYISEfoUg")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReportingDateTime { get; init; }

    /// <summary>
    /// Information on funding sources used to finance margin loans.
    /// </summary>
    [IsoId("_S2Wcm8K9EeuCIrYISEfoUg")]
    [DisplayName("Funding Source")]
    [IsoXmlTag("FndgSrc")]
    public ValueList<FundingSource3> FundingSource { get; init; } = [];

    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_S2WcncK9EeuCIrYISEfoUg")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public ReconciliationFlag2? ReconciliationFlag { get; init; }

    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_S2Wcn8K9EeuCIrYISEfoUg")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public required ContractModification3 ContractModification { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_S2WcocK9EeuCIrYISEfoUg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
