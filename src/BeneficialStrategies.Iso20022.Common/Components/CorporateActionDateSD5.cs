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
[IsoId("_1hOp4TL3EeKU9IrkkToqcw_902048104")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDateSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDateSD5( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1hOp4jL3EeKU9IrkkToqcw_-768158364")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [IsoId("_1hOp4zL3EeKU9IrkkToqcw_-40963530")]
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
    [IsoId("_1hOp5DL3EeKU9IrkkToqcw_-1151874949")]
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
    [IsoId("_1hOp5TL3EeKU9IrkkToqcw_1682939943")]
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
    /// Cutoff date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cutoff date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [IsoId("_1hYa4DL3EeKU9IrkkToqcw_-1884832519")]
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
    [IsoId("_1hYa4TL3EeKU9IrkkToqcw_1299223358")]
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
    [IsoId("_1hYa4jL3EeKU9IrkkToqcw_2008057450")]
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
    [IsoId("_1hYa4zL3EeKU9IrkkToqcw_-1559715012")]
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
    [IsoId("_1hYa5DL3EeKU9IrkkToqcw_1624340865")]
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
    [IsoId("_1hYa5TL3EeKU9IrkkToqcw_2125928435")]
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
    
    
    #nullable disable
    
}
