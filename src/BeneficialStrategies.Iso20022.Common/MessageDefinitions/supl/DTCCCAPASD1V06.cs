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
/// This record is an implementation of the supl.010.001.06 ISO standard message type.
/// The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(
    @"The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message."
)]
[IsoId("_LAGyS75MEeexmbB7KsjCwA")]
[DisplayName("DTCCCAPASD 1 V")]
public record DTCCCAPASD1V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.010.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.010.001.06";

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
    [IsoId("_LAGyTb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD30? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_LAGyVb5MEeexmbB7KsjCwA")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_LAGyV75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Balance Details")]
    [IsoXmlTag("CorpActnBalDtls")]
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_LAGyWb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD18? CorporateActionDetails { get; init; }

    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_LAGyY75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    public ValueList<CorporateActionMovementSecuritiesMovementDetailsSD5> CorporateActionMovementSecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_LAGya75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    public ValueList<CorporateActionMovementCashMovementDetailsSD5> CorporateActionMovementCashMovementDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_LAGyc75MEeexmbB7KsjCwA")]
    [DisplayName("Option Transaction Details")]
    [IsoXmlTag("OptnTxDtls")]
    public ValueList<OptionTransactionDetailsSD3> OptionTransactionDetails { get; init; } = [];
}
