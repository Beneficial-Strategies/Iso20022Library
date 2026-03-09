// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
[IsoId("_bmP1AeaKEei5aPS232E3Mw")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_cOHGQeaKEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [IsoId("_cOHGQ-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Last Day For Early Redemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCLastDayForEarlyRed")]
    #endif
    [IsoXmlTag("DTCLastDayForEarlyRed")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DTCLastDayForEarlyRedemption { get; init; } 
    #else
    public System.DateOnly? DTCLastDayForEarlyRedemption { get; set; } 
    #endif
    
    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_cOHGS-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Position Capture Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCPosCaptrDt")]
    #endif
    [IsoXmlTag("DTCPosCaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DTCPositionCaptureDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DTCPositionCaptureDate { get; init; } 
    #else
    public System.DateOnly? DTCPositionCaptureDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC&apos;s records.
    /// </summary>
    [IsoId("_cOHGU-aKEei5aPS232E3Mw")]
    [DisplayName("New York Cut Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewYorkCutOffDt")]
    #endif
    [IsoXmlTag("NewYorkCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NewYorkCutOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NewYorkCutOffDate { get; init; } 
    #else
    public System.DateOnly? NewYorkCutOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Cut Off date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cut off date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [IsoId("_cOHGW-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Extended Cut Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCXtndedCutOffDt")]
    #endif
    [IsoXmlTag("DTCXtndedCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DTCExtendedCutOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DTCExtendedCutOffDate { get; init; } 
    #else
    public System.DateOnly? DTCExtendedCutOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    [IsoId("_cOHGY-aKEei5aPS232E3Mw")]
    [DisplayName("Effective Date By Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDtByXchg")]
    #endif
    [IsoXmlTag("FctvDtByXchg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EffectiveDateByExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EffectiveDateByExchange { get; init; } 
    #else
    public System.DateOnly? EffectiveDateByExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    [IsoId("_cOHGa-aKEei5aPS232E3Mw")]
    [DisplayName("Date Declared Worthless")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDclrdWrthls")]
    #endif
    [IsoXmlTag("DtDclrdWrthls")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateDeclaredWorthless { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateDeclaredWorthless { get; init; } 
    #else
    public System.DateOnly? DateDeclaredWorthless { get; set; } 
    #endif
    
    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    [IsoId("_cOHGc-aKEei5aPS232E3Mw")]
    [DisplayName("Delete Worthless Security Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DelWrthlsSctyDt")]
    #endif
    [IsoXmlTag("DelWrthlsSctyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DeleteWorthlessSecurityDate { get; init; } 
    #else
    public System.DateOnly? DeleteWorthlessSecurityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_cOHGe-aKEei5aPS232E3Mw")]
    [DisplayName("DTC Exit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCExitDt")]
    #endif
    [IsoXmlTag("DTCExitDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DTCExitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DTCExitDate { get; init; } 
    #else
    public System.DateOnly? DTCExitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    [IsoId("_cOHGg-aKEei5aPS232E3Mw")]
    [DisplayName("Subscription Begin Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptBegnDt")]
    #endif
    [IsoXmlTag("SbcptBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SubscriptionBeginDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SubscriptionBeginDate { get; init; } 
    #else
    public System.DateOnly? SubscriptionBeginDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date used for determining client position for allocating rights.
    /// </summary>
    [IsoId("_cOHGi-aKEei5aPS232E3Mw")]
    [DisplayName("Rights Distribution As Of Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsDstrbtnAsOfDt")]
    #endif
    [IsoXmlTag("RghtsDstrbtnAsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RightsDistributionAsOfDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RightsDistributionAsOfDate { get; init; } 
    #else
    public System.DateOnly? RightsDistributionAsOfDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the rights allocation occurred.
    /// </summary>
    [IsoId("_cOHGjeaKEei5aPS232E3Mw")]
    [DisplayName("Rights Distribution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsDstrbtnDt")]
    #endif
    [IsoXmlTag("RghtsDstrbtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RightsDistributionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RightsDistributionDate { get; init; } 
    #else
    public System.DateOnly? RightsDistributionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date which defines the timing of the Dividend Equivalent payment as per IRS regulation 871m.
    /// </summary>
    [IsoId("_mT8t0OaKEei5aPS232E3Mw")]
    [DisplayName("Timing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmgDt")]
    #endif
    [IsoXmlTag("TmgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TimingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TimingDate { get; init; } 
    #else
    public System.DateOnly? TimingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
