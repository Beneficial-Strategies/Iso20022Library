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
/// This record is an implementation of the supl.009.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_NiVMi6MrEe-4O7NbwmwJkQ")]
[DisplayName("DTCCCAPASD1V11")]
public record DTCCCAPASD1V11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.11";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Corporate Action Balance Details.
    /// </summary>
    [DisplayName("Corporate Action Balance Details")]
    [IsoXmlTag("CorpActnBalDtls")]
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; }

    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD18? CorporateActionDetails { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD58? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Corporate Action Movement Cash Movement Details.
    /// </summary>
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    public ValueList<CorporateActionMovementCashMovementDetailsSD5> CorporateActionMovementCashMovementDetails { get; init; } =
        [];

    /// <summary>
    /// Corporate Action Movement Securities Movement Details.
    /// </summary>
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    public ValueList<CorporateActionMovementSecuritiesMovementDetailsSD5> CorporateActionMovementSecuritiesMovementDetails { get; init; } =
        [];

    /// <summary>
    /// Option Transaction Details.
    /// </summary>
    [DisplayName("Option Transaction Details")]
    [IsoXmlTag("OptnTxDtls")]
    public ValueList<OptionTransactionDetailsSD3> OptionTransactionDetails { get; init; } = [];

    /// <summary>
    /// Underlying Security.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; init; }
}

// Since DTCCCAPASD1V11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAPASD1V11.
