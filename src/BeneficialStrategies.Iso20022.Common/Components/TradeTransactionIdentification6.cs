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
[IsoId("_Sm4DUa4ZEemB_csI4yyKLA")]
[DisplayName("Trade Transaction Identification")]
public record TradeTransactionIdentification6
{
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_Sry_ka4ZEemB_csI4yyKLA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_Sry_k64ZEemB_csI4yyKLA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; }

    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_Sry_la4ZEemB_csI4yyKLA")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_Sry_l64ZEemB_csI4yyKLA")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement1? MasterAgreement { get; init; }
}
