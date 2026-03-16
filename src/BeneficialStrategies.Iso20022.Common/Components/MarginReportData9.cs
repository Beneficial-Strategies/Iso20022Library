// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin Report Data9.
/// </summary>
[IsoId("_THILucEkEe66laxnCpxfpw")]
[DisplayName("Margin Report Data9")]
public partial record MarginReportData9
{
    #nullable enable

    /// <summary>
    /// Collateral.
    /// </summary>
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public required MarginCollateralReport5 Collateral { get; init; } 

    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 

    /// <summary>
    /// Counterparty Rating Threshold Indicator.
    /// </summary>
    [DisplayName("Counterparty Rating Threshold Indicator")]
    [IsoXmlTag("CtrPtyRatgThrshldInd")]
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 

    /// <summary>
    /// Counterparty Rating Trigger Indicator.
    /// </summary>
    [DisplayName("Counterparty Rating Trigger Indicator")]
    [IsoXmlTag("CtrPtyRatgTrggrInd")]
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 

    /// <summary>
    /// Event Date.
    /// </summary>
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    public IsoISODate? EventDate { get; init; } 

    /// <summary>
    /// Posted Margin Or Collateral.
    /// </summary>
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 

    /// <summary>
    /// Received Margin Or Collateral.
    /// </summary>
    [DisplayName("Received Margin Or Collateral")]
    [IsoXmlTag("RcvdMrgnOrColl")]
    public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 

    /// <summary>
    /// Reporting Time Stamp.
    /// </summary>
    [DisplayName("Reporting Time Stamp")]
    [IsoXmlTag("RptgTmStmp")]
    public IsoISODateTime? ReportingTimeStamp { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Technical Attributes.
    /// </summary>
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes6? TechnicalAttributes { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
