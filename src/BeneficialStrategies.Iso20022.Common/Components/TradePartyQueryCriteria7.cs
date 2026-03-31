// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Party Query Criteria7.
/// </summary>
[IsoId("_hRAnD_rgEe2mU4Wi2q3MzQ")]
[DisplayName("Trade Party Query Criteria7")]
public record TradePartyQueryCriteria7
{
    /// <summary>
    /// Beneficiary.
    /// </summary>
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public TradePartyIdentificationQuery10Choice_? Beneficiary { get; init; }

    /// <summary>
    /// Broker.
    /// </summary>
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public TradePartyIdentificationQuery11Choice_? Broker { get; init; }

    /// <summary>
    /// CCP.
    /// </summary>
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public TradePartyIdentificationQuery11Choice_? CCP { get; init; }

    /// <summary>
    /// Clearing Member.
    /// </summary>
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public TradePartyIdentificationQuery10Choice_? ClearingMember { get; init; }

    /// <summary>
    /// Entity Responsible For Report.
    /// </summary>
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public TradePartyIdentificationQuery11Choice_? EntityResponsibleForReport { get; init; }

    /// <summary>
    /// Operator.
    /// </summary>
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; }

    /// <summary>
    /// Other Counterparty.
    /// </summary>
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public TradePartyIdentificationQuery10Choice_? OtherCounterparty { get; init; }

    /// <summary>
    /// Reporting Counterparty.
    /// </summary>
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public TradePartyIdentificationQuery10Choice_? ReportingCounterparty { get; init; }

    /// <summary>
    /// Submitting Agent.
    /// </summary>
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public TradePartyIdentificationQuery11Choice_? SubmittingAgent { get; init; }
}
