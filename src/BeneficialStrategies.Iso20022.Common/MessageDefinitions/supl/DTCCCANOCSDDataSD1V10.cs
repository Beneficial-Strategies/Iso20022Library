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
/// This record is an implementation of the supl.001.001.10 ISO standard message type.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Description(
    @"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message."
)]
[IsoId("_LAGx8b5MEeexmbB7KsjCwA")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
public record DTCCCANOCSDDataSD1V10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_LAGx875MEeexmbB7KsjCwA")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_LAGx9b5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD28? CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_LAGx975MEeexmbB7KsjCwA")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD15? UnderlyingSecurity { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_LAGx-b5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD17? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_LAGx-75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD8? CorporateActionDateDetails { get; init; }

    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_LAGx_b5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Price Details")]
    [IsoXmlTag("CorpActnPricDtls")]
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_LAGx_75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Period Details")]
    [IsoXmlTag("CorpActnPrdDtls")]
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_LAGyAb5MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_LAGyA75MEeexmbB7KsjCwA")]
    [DisplayName("Corporate Action Securities Quantity")]
    [IsoXmlTag("CorpActnSctiesQty")]
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; init; }

    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_LAGyBb5MEeexmbB7KsjCwA")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<CorporateActionOptionSD11> OptionDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_LAGyB75MEeexmbB7KsjCwA")]
    [DisplayName("Option Date Details")]
    [IsoXmlTag("OptnDtDtls")]
    public ValueList<CorporateActionDateSD9> OptionDateDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_LAGyCb5MEeexmbB7KsjCwA")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOptionSD9> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_LAGyC75MEeexmbB7KsjCwA")]
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public ValueList<FinancialInstrumentAttributesSD16> SecuritiesMovementSecurityDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_LAGyDb5MEeexmbB7KsjCwA")]
    [DisplayName("Securities Movement Rate Details")]
    [IsoXmlTag("SctiesMvmntRateDtls")]
    public ValueList<CorporateActionRateSD10> SecuritiesMovementRateDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_LAGyD75MEeexmbB7KsjCwA")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    public ValueList<CorporateActionPriceSD5> SecuritiesMovementCashInLieuDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_LAGyEb5MEeexmbB7KsjCwA")]
    [DisplayName("Securities Movement Fraction Disposition")]
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    public ValueList<FractionDispositionTypeSD3> SecuritiesMovementFractionDisposition { get; init; } = [];

    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_LAGyE75MEeexmbB7KsjCwA")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOptionSD11> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Information to be extended new agent block. Used when required ISO agent type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_LAGyFb5MEeexmbB7KsjCwA")]
    [DisplayName("New Agent")]
    [IsoXmlTag("NewAgt")]
    public ValueList<PartyIdentificationSD5> NewAgent { get; init; } = [];

    /// <summary>
    /// Provides additional information to agent details (to message agent like "issuer agent", "reselling agent"). Used when required "ISO agent type" exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_LAGyF75MEeexmbB7KsjCwA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public ValueList<PartyIdentificationSD6> Agent { get; init; } = [];
}
