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
[IsoId("__iW9QcIVEeunlsN4rAgJZA")]
[DisplayName("Trade Transaction Identification")]
public record TradeTransactionIdentification15
{
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("__kaywcIVEeunlsN4rAgJZA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("__kayw8IVEeunlsN4rAgJZA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; }

    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("__kayxcIVEeunlsN4rAgJZA")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("__kayx8IVEeunlsN4rAgJZA")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; }

    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    [IsoId("__kayycIVEeunlsN4rAgJZA")]
    [DisplayName("Agent Lender")]
    [IsoXmlTag("AgtLndr")]
    public OrganisationIdentification15Choice_? AgentLender { get; init; }

    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    [IsoId("__kayy8IVEeunlsN4rAgJZA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; }
}
