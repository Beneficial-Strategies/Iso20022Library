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
/// This record is an implementation of the supl.011.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_NiVMu6MrEe-4O7NbwmwJkQ")]
[DisplayName("DTCCCACOSD1V11")]
public record DTCCCACOSD1V11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.11";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to account balance.
    /// </summary>
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalanceSD14> AccountBalance { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to corporate action confirmation cash movement details.
    /// </summary>
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    public ValueList<CorporateActionConfirmationCashMovementDetailsSD5> CorporateActionConfirmationCashMovementDetails { get; init; } =
        [];

    /// <summary>
    /// Information to be extended as supplementary data to corporate action confirmation details.
    /// </summary>
    [DisplayName("Corporate Action Confirmation Details")]
    [IsoXmlTag("CorpActnConfDtls")]
    public CorporateActionConfirmationDetailsSD2? CorporateActionConfirmationDetails { get; init; }

    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    public ValueList<CorporateActionConfirmationSecuritiesMovementDetailsSD6> CorporateActionConfirmationSecuritiesMovementDetails { get; init; } =
        [];

    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD20? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action general information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD60? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [DisplayName("Option Transaction Details")]
    [IsoXmlTag("OptnTxDtls")]
    public ValueList<OptionTransactionSD6> OptionTransactionDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; init; }
}

// Since DTCCCACOSD1V11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACOSD1V11.
