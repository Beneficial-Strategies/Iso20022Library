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
[IsoId("_1d8sZDL3EeKU9IrkkToqcw_1274784693")]
[DisplayName("Corporate Action Date SD")]
public partial record CorporateActionDateSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1d8sZTL3EeKU9IrkkToqcw_-682923362")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [IsoId("_1d8sZjL3EeKU9IrkkToqcw_1731738294")]
    [DisplayName("DTC Last Day For Early Redemption")]
    [IsoXmlTag("DTCLastDayForEarlyRed")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; } 
    
    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1eGdYDL3EeKU9IrkkToqcw_620826875")]
    [DisplayName("DTC Position Capture Date")]
    [IsoXmlTag("DTCPosCaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCPositionCaptureDate { get; init; } 
    
    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC&apos;s records.
    /// </summary>
    [IsoId("_1eGdYTL3EeKU9IrkkToqcw_-228836093")]
    [DisplayName("New York Cut Off Date")]
    [IsoXmlTag("NewYorkCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewYorkCutOffDate { get; init; } 
    
    /// <summary>
    /// Cutoff date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cutoff date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [IsoId("_1eGdYjL3EeKU9IrkkToqcw_-2109141733")]
    [DisplayName("DTC Extended Cut Off Date")]
    [IsoXmlTag("DTCXtndedCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExtendedCutOffDate { get; init; } 
    
    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    [IsoId("_1eGdYzL3EeKU9IrkkToqcw_1074914144")]
    [DisplayName("Effective Date By Exchange")]
    [IsoXmlTag("FctvDtByXchg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDateByExchange { get; init; } 
    
    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    [IsoId("_1eGdZDL3EeKU9IrkkToqcw_-628364830")]
    [DisplayName("Date Declared Worthless")]
    [IsoXmlTag("DtDclrdWrthls")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateDeclaredWorthless { get; init; } 
    
    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    [IsoId("_1eGdZTL3EeKU9IrkkToqcw_-1478027798")]
    [DisplayName("Delete Worthless Security Date")]
    [IsoXmlTag("DelWrthlsSctyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; } 
    
    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1eGdZjL3EeKU9IrkkToqcw_-174277561")]
    [DisplayName("DTC Exit Date")]
    [IsoXmlTag("DTCExitDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DTCExitDate { get; init; } 
    
    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    [IsoId("_1ePnUDL3EeKU9IrkkToqcw_-892080772")]
    [DisplayName("Subscription Begin Date")]
    [IsoXmlTag("SbcptBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SubscriptionBeginDate { get; init; } 
    
    /// <summary>
    /// Date on which a company files a petition for reorganisation under Chapter 11 of the United States Bankruptcy Code.
    /// </summary>
    [IsoId("_1ePnUTL3EeKU9IrkkToqcw_1895233819")]
    [DisplayName("Filing Date")]
    [IsoXmlTag("FilgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FilingDate { get; init; } 
    
    /// <summary>
    /// Hearing date as set by the court. Hearing date is material to the shareholder/interested party as this may be the last opportunity to make a case against/for a settlement.
    /// </summary>
    [IsoId("_1ePnUjL3EeKU9IrkkToqcw_14928179")]
    [DisplayName("Hearing Date")]
    [IsoXmlTag("HrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? HearingDate { get; init; } 
    
    
    #nullable disable
    
}
