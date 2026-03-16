// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information regarding custodian service record.
/// </summary>
[IsoId("_1Q1ddDL3EeKU9IrkkToqcw_-1224843836")]
[DisplayName("Custodian Details SD")]
public record CustodianDetailsSD1
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Q1ddTL3EeKU9IrkkToqcw_-1664439967")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Unique identifier of a custodian corporate action record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcDL3EeKU9IrkkToqcw_1455084768")]
    [DisplayName("Custodian Corporate Action Record Identification")]
    [IsoXmlTag("CtdnCorpActnRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CustodianCorporateActionRecordIdentification { get; init; }

    /// <summary>
    /// Indicates the state of the agreement of the custodian record when compared to composite record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcTL3EeKU9IrkkToqcw_751485142")]
    [DisplayName("Agree Indicator")]
    [IsoXmlTag("AgrInd")]
    public required CustodianRecordAgreementType1Code AgreeIndicator { get; init; }

    /// <summary>
    /// Indicates state of the details of the custodian record on the system. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcjL3EeKU9IrkkToqcw_2043159221")]
    [DisplayName("Completeness Indicator")]
    [IsoXmlTag("CmpltnsInd")]
    public required CustodianRecordCompletenessType1Code CompletenessIndicator { get; init; }

    /// <summary>
    /// Represents the status of custodian activity when applicable.
    /// </summary>
    [IsoId("_1Q_OczL3EeKU9IrkkToqcw_1424851471")]
    [DisplayName("Custodian Action Indicator")]
    [IsoXmlTag("CtdnActnInd")]
    public CustodianAction1Code? CustodianActionIndicator { get; init; }

    /// <summary>
    /// Indicates what action needs to be taken by the GCA (Global Corporate Action) validation service for this particular record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdDL3EeKU9IrkkToqcw_-356832207")]
    [DisplayName("GCA Action Indicator")]
    [IsoXmlTag("GCAActnInd")]
    public GCAActionType1Code? GCAActionIndicator { get; init; }

    /// <summary>
    /// BIC which is configured as a recipient of the custodian record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdTL3EeKU9IrkkToqcw_948233771")]
    [DisplayName("Receiving BIC")]
    [IsoXmlTag("RcvgBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier ReceivingBIC { get; init; }

    /// <summary>
    /// BIC which is configured as a sender of the custodian record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdjL3EeKU9IrkkToqcw_-1028930372")]
    [DisplayName("Originating BIC")]
    [IsoXmlTag("OrgtgBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier OriginatingBIC { get; init; }

    /// <summary>
    /// Indicates whether the event security of the corresponding composite record is on SOI (security of interest) subscription. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1RIYYDL3EeKU9IrkkToqcw_914356142")]
    [DisplayName("Composite Not In Subscription Flag")]
    [IsoXmlTag("CmpsitNotInSbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CompositeNotInSubscriptionFlag { get; init; }

    /// <summary>
    /// Provides selected corporate action events message details extracted from the related custodian messages received. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1RIYYTL3EeKU9IrkkToqcw_1582463489")]
    [DisplayName("Related Custodian Message Details")]
    [IsoXmlTag("RltdCtdnMsgDtls")]
    public RelatedCustodianMessageDetailsSD1? RelatedCustodianMessageDetails { get; init; }
}
