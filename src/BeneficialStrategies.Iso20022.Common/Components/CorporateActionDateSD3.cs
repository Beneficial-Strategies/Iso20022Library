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
[IsoId("_1d8sZDL3EeKU9IrkkToqcw_1274784693")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDateSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDateSD3( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1d8sZTL3EeKU9IrkkToqcw_-682923362")]
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
    [IsoId("_1d8sZjL3EeKU9IrkkToqcw_1731738294")]
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
    [IsoId("_1eGdYDL3EeKU9IrkkToqcw_620826875")]
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
    [IsoId("_1eGdYTL3EeKU9IrkkToqcw_-228836093")]
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
    [IsoId("_1eGdYjL3EeKU9IrkkToqcw_-2109141733")]
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
    [IsoId("_1eGdYzL3EeKU9IrkkToqcw_1074914144")]
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
    [IsoId("_1eGdZDL3EeKU9IrkkToqcw_-628364830")]
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
    [IsoId("_1eGdZTL3EeKU9IrkkToqcw_-1478027798")]
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
    [IsoId("_1eGdZjL3EeKU9IrkkToqcw_-174277561")]
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
    [IsoId("_1ePnUDL3EeKU9IrkkToqcw_-892080772")]
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
    /// Date on which a company files a petition for reorganisation under Chapter 11 of the United States Bankruptcy Code.
    /// </summary>
    [IsoId("_1ePnUTL3EeKU9IrkkToqcw_1895233819")]
    [DisplayName("Filing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FilgDt")]
    #endif
    [IsoXmlTag("FilgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FilingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FilingDate { get; init; } 
    #else
    public System.DateOnly? FilingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Hearing date as set by the court. Hearing date is material to the shareholder/interested party as this may be the last opportunity to make a case against/for a settlement.
    /// </summary>
    [IsoId("_1ePnUjL3EeKU9IrkkToqcw_14928179")]
    [DisplayName("Hearing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrgDt")]
    #endif
    [IsoXmlTag("HrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? HearingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? HearingDate { get; init; } 
    #else
    public System.DateOnly? HearingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
