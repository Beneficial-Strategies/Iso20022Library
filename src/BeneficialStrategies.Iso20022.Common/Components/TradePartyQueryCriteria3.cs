// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the queried trade parties.
/// </summary>
[IsoId("_QAVRoZQTEeiok48Eh9lW9Q")]
[DisplayName("Trade Party Query Criteria")]
public record TradePartyQueryCriteria3
{
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_QLO6E5QTEeiok48Eh9lW9Q")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; }

    /// <summary>
    /// Identifies the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_QLO6FZQTEeiok48Eh9lW9Q")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public TradePartyIdentificationQuery8? ReportingCounterparty { get; init; }

    /// <summary>
    /// Identifies the other counterparty of the contract.
    /// </summary>
    [IsoId("_QLO6F5QTEeiok48Eh9lW9Q")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public TradePartyIdentificationQuery8? OtherCounterparty { get; init; }

    /// <summary>
    /// Identifies the party subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_QLO6GZQTEeiok48Eh9lW9Q")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public TradePartyIdentificationQuery8? Beneficiary { get; init; }

    /// <summary>
    /// Identifies the submitting agent of the reported of the contract.
    /// </summary>
    [IsoId("_QLO6G5QTEeiok48Eh9lW9Q")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public TradePartyIdentificationQuery8? SubmittingAgent { get; init; }

    /// <summary>
    /// Identifies the broker who acts as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_QLO6HZQTEeiok48Eh9lW9Q")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public TradePartyIdentificationQuery8? Broker { get; init; }

    /// <summary>
    /// Unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_QLO6H5QTEeiok48Eh9lW9Q")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public TradePartyIdentificationQuery8? CCP { get; init; }
}
