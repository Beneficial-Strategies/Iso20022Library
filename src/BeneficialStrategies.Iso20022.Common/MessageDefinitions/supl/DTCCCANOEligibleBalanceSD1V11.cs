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
/// This record is an implementation of the supl.007.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message."
)]
[IsoId("_Vk6qRzDmEey2N-DB7H7A5A")]
[DisplayName("DTCCCANO Eligible Balance SD 1 V")]
public record DTCCCANOEligibleBalanceSD1V11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.007.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOElgblBalSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.007.001.11";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_Vk6qSTDmEey2N-DB7H7A5A")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD49? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_Vk6qSzDmEey2N-DB7H7A5A")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to account balance for distribution events.
    /// </summary>
    [IsoId("_Vk6qTTDmEey2N-DB7H7A5A")]
    [DisplayName("Distribution Account Balance")]
    [IsoXmlTag("DstrbtnAcctBal")]
    public AccountBalanceSD10? DistributionAccountBalance { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to account balance for redemptions events.
    /// </summary>
    [IsoId("_Vk6qTzDmEey2N-DB7H7A5A")]
    [DisplayName("Redemption Account Balance")]
    [IsoXmlTag("RedAcctBal")]
    public AccountBalanceSD11? RedemptionAccountBalance { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to account balance for reorganisation events.
    /// </summary>
    [IsoId("_Vk6qUTDmEey2N-DB7H7A5A")]
    [DisplayName("Reorganisation Account Balance")]
    [IsoXmlTag("ReorgAcctBal")]
    public AccountBalanceSD12? ReorganisationAccountBalance { get; init; }
}

// Since DTCCCANOEligibleBalanceSD1V11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOEligibleBalanceSD1V11.
