// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
[IsoId("_ETPUgb5QEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Date SD")]
public record CorporateActionDateSD8
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_Ejwcwb5QEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [IsoId("_Ejwcw75QEeexmbB7KsjCwA")]
    [DisplayName("DTC Last Day For Early Redemption")]
    [IsoXmlTag("DTCLastDayForEarlyRed")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; }

    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_Ejwcy75QEeexmbB7KsjCwA")]
    [DisplayName("DTC Position Capture Date")]
    [IsoXmlTag("DTCPosCaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCPositionCaptureDate { get; init; }

    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC&apos;s records.
    /// </summary>
    [IsoId("_Ejwc075QEeexmbB7KsjCwA")]
    [DisplayName("New York Cut Off Date")]
    [IsoXmlTag("NewYorkCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewYorkCutOffDate { get; init; }

    /// <summary>
    /// Cut Off date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cut off date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [IsoId("_Ejwc275QEeexmbB7KsjCwA")]
    [DisplayName("DTC Extended Cut Off Date")]
    [IsoXmlTag("DTCXtndedCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExtendedCutOffDate { get; init; }

    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    [IsoId("_Ejwc475QEeexmbB7KsjCwA")]
    [DisplayName("Effective Date By Exchange")]
    [IsoXmlTag("FctvDtByXchg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDateByExchange { get; init; }

    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    [IsoId("_Ejwc675QEeexmbB7KsjCwA")]
    [DisplayName("Date Declared Worthless")]
    [IsoXmlTag("DtDclrdWrthls")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateDeclaredWorthless { get; init; }

    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    [IsoId("_Ejwc875QEeexmbB7KsjCwA")]
    [DisplayName("Delete Worthless Security Date")]
    [IsoXmlTag("DelWrthlsSctyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; }

    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_Ejwc-75QEeexmbB7KsjCwA")]
    [DisplayName("DTC Exit Date")]
    [IsoXmlTag("DTCExitDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExitDate { get; init; }

    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    [IsoId("_EjwdA75QEeexmbB7KsjCwA")]
    [DisplayName("Subscription Begin Date")]
    [IsoXmlTag("SbcptBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SubscriptionBeginDate { get; init; }

    /// <summary>
    /// Date used for determining client position for allocating rights.
    /// </summary>
    [IsoId("_Y7LjkL_qEeeb2ZBoAlSG1Q")]
    [DisplayName("Rights Distribution As Of Date")]
    [IsoXmlTag("RghtsDstrbtnAsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RightsDistributionAsOfDate { get; init; }

    /// <summary>
    /// Date at which the rights allocation occurred.
    /// </summary>
    [IsoId("_n1j4ML_qEeeb2ZBoAlSG1Q")]
    [DisplayName("Rights Distribution Date")]
    [IsoXmlTag("RghtsDstrbtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RightsDistributionDate { get; init; }
}
