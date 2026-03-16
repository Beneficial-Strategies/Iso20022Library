// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_xpfEAc29Eeu7SNBdMhkjcA")]
[DisplayName("Trade Transaction Identification")]
public record TradeTransactionIdentification20
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_AG25QM3OEeuiU4QSC_BouQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_xrWFMc29Eeu7SNBdMhkjcA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_xrWFM829Eeu7SNBdMhkjcA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying that counterparty in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_K00cINAQEeuvMdMKUKkEeQ")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; }

    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_xrWFNc29Eeu7SNBdMhkjcA")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_xrWFN829Eeu7SNBdMhkjcA")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; }

    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("_xrWFOc29Eeu7SNBdMhkjcA")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public OrganisationIdentification15Choice_? AgentLender { get; init; }

    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("_xrWFO829Eeu7SNBdMhkjcA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; }
}
