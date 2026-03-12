// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
[IsoId("_bmP1AeaKEei5aPS232E3Mw")]
[DisplayName("Corporate Action Date SD")]
public partial record CorporateActionDateSD10
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_cOHGQeaKEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [IsoId("_cOHGQ-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Last Day For Early Redemption")]
    [IsoXmlTag("DTCLastDayForEarlyRed")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; } 
    
    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_cOHGS-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Position Capture Date")]
    [IsoXmlTag("DTCPosCaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCPositionCaptureDate { get; init; } 
    
    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC&apos;s records.
    /// </summary>
    [IsoId("_cOHGU-aKEei5aPS232E3Mw")]
    [DisplayName("New York Cut Off Date")]
    [IsoXmlTag("NewYorkCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewYorkCutOffDate { get; init; } 
    
    /// <summary>
    /// Cut Off date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cut off date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [IsoId("_cOHGW-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Extended Cut Off Date")]
    [IsoXmlTag("DTCXtndedCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExtendedCutOffDate { get; init; } 
    
    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    [IsoId("_cOHGY-aKEei5aPS232E3Mw")]
    [DisplayName("Effective Date By Exchange")]
    [IsoXmlTag("FctvDtByXchg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDateByExchange { get; init; } 
    
    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    [IsoId("_cOHGa-aKEei5aPS232E3Mw")]
    [DisplayName("Date Declared Worthless")]
    [IsoXmlTag("DtDclrdWrthls")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateDeclaredWorthless { get; init; } 
    
    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    [IsoId("_cOHGc-aKEei5aPS232E3Mw")]
    [DisplayName("Delete Worthless Security Date")]
    [IsoXmlTag("DelWrthlsSctyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; } 
    
    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_cOHGe-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Exit Date")]
    [IsoXmlTag("DTCExitDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExitDate { get; init; } 
    
    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    [IsoId("_cOHGg-aKEei5aPS232E3Mw")]
    [DisplayName("Subscription Begin Date")]
    [IsoXmlTag("SbcptBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SubscriptionBeginDate { get; init; } 
    
    /// <summary>
    /// Date used for determining client position for allocating rights.
    /// </summary>
    [IsoId("_cOHGi-aKEei5aPS232E3Mw")]
    [DisplayName("Rights Distribution As Of Date")]
    [IsoXmlTag("RghtsDstrbtnAsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RightsDistributionAsOfDate { get; init; } 
    
    /// <summary>
    /// Date at which the rights allocation occurred.
    /// </summary>
    [IsoId("_cOHGjeaKEei5aPS232E3Mw")]
    [DisplayName("Rights Distribution Date")]
    [IsoXmlTag("RghtsDstrbtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RightsDistributionDate { get; init; } 
    
    /// <summary>
    /// Date which defines the timing of the Dividend Equivalent payment as per IRS regulation 871m.
    /// </summary>
    [IsoId("_mT8t0OaKEei5aPS232E3Mw")]
    [DisplayName("Timing Date")]
    [IsoXmlTag("TmgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TimingDate { get; init; } 
    
    
    #nullable disable
    
}
