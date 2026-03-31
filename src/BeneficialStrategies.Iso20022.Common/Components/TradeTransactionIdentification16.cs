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
[IsoId("_hY22B8K4EeuFNp8LZAnorg")]
[DisplayName("Trade Transaction Identification")]
public record TradeTransactionIdentification16
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_Ecgq4M3OEeuiU4QSC_BouQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_haIoYcK4EeuFNp8LZAnorg")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_haIoY8K4EeuFNp8LZAnorg")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying that the Financial counterparty responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_rOzncMK4EeuFNp8LZAnorg")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_haIoZcK4EeuFNp8LZAnorg")]
    [DisplayName("Collateral Portfolio Identification")]
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? CollateralPortfolioIdentification { get; init; }
}
