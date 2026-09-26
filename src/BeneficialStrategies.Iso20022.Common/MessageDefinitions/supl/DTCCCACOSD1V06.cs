// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.011.001.06 ISO standard message type.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_LAGygb5MEeexmbB7KsjCwA")]
[DisplayName("DTCCCACOSD 1 V")]
public record DTCCCACOSD1V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_LAGyhb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD32? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_LAGyjb5MEeexmbB7KsjCwA")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_LAGyj75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD20? CorporateActionDetails { get; init; }

    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_LAGykb5MEeexmbB7KsjCwA")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalanceSD13> AccountBalance { get; init; } = [];

    /// <summary>
    /// Information to be extended as corporate action confirmation details.
    /// </summary>
    [IsoId("_LAGyk75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Confirmation Details")]
    [IsoXmlTag("CorpActnConfDtls")]
    public CorporateActionConfirmationDetailsSD2? CorporateActionConfirmationDetails { get; init; }

    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_LAGylb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    public ValueList<CorporateActionConfirmationSecuritiesMovementDetailsSD6> CorporateActionConfirmationSecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_LAGynb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    public ValueList<CorporateActionConfirmationCashMovementDetailsSD5> CorporateActionConfirmationCashMovementDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_LAGypb5MEeexmbB7KsjCwA")]
    [DisplayName("Option Transaction Details")]
    [IsoXmlTag("OptnTxDtls")]
    public ValueList<OptionTransactionDetailsSD4> OptionTransactionDetails { get; init; } = [];
}
