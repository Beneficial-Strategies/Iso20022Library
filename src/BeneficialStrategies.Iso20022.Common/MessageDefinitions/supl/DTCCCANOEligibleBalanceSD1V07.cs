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
/// This record is an implementation of the supl.005.001.07 ISO standard message type.
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message."
)]
[IsoId("_LAGyI75MEeexmbB7KsjCwA")]
[DisplayName("DTCCCANOEligible Balance SD 1 V")]
public record DTCCCANOEligibleBalanceSD1V07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.005.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOEligibleBalanceSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.005.001.07";

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
    [IsoId("_LAGyJb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD30? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_LAGyJ75MEeexmbB7KsjCwA")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Extension block for the information to be extended as account balance for distribution events.
    /// </summary>
    [IsoId("_LAGyKb5MEeexmbB7KsjCwA")]
    [DisplayName("Distribution Account Balance")]
    [IsoXmlTag("DstrbtnAcctBal")]
    public ValueList<AccountBalanceSD10> DistributionAccountBalance { get; init; } = [];

    /// <summary>
    /// Extension block for the information to be extended as account balance for redemptions events.
    /// </summary>
    [IsoId("_LAGyK75MEeexmbB7KsjCwA")]
    [DisplayName("Redemption Account Balance")]
    [IsoXmlTag("RedAcctBal")]
    public AccountBalanceSD11? RedemptionAccountBalance { get; init; }

    /// <summary>
    /// Extension block for the information to be extended as account balance for reorganisation events.
    /// </summary>
    [IsoId("_LAGyLb5MEeexmbB7KsjCwA")]
    [DisplayName("Reorganisation Account Balance")]
    [IsoXmlTag("ReorgAcctBal")]
    public AccountBalanceSD12? ReorganisationAccountBalance { get; init; }
}
