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
/// Provides additional information regarding corporate action options date details.
/// </summary>
[IsoId("_CPKmse2KEeiWtrflKsFqHg")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD11
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
    [IsoId("_CzLSse2KEeiWtrflKsFqHg")]
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
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    [IsoId("_CzLSs-2KEeiWtrflKsFqHg")]
    [DisplayName("Actual Early Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ActualEarlyExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ActualEarlyExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? ActualEarlyExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_CzLSte2KEeiWtrflKsFqHg")]
    [DisplayName("Actual Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlPrtctXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ActualProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ActualProtectExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? ActualProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    [IsoId("_CzLSt-2KEeiWtrflKsFqHg")]
    [DisplayName("Actual Early Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyPrtctXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ActualEarlyProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ActualEarlyProtectExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? ActualEarlyProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    [IsoId("_CzLSue2KEeiWtrflKsFqHg")]
    [DisplayName("DTC Early Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCEarlyPrtctXprtnDt")]
    #endif
    [IsoXmlTag("DTCEarlyPrtctXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? DTCEarlyProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? DTCEarlyProtectExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? DTCEarlyProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_CzLSu-2KEeiWtrflKsFqHg")]
    [DisplayName("Actual Early Cover Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlEarlyCoverPrtctXprtnDt")]
    #endif
    [IsoXmlTag("ActlEarlyCoverPrtctXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ActualEarlyCoverProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ActualEarlyCoverProtectExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? ActualEarlyCoverProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    [IsoId("_CzLSve2KEeiWtrflKsFqHg")]
    [DisplayName("DTC Early Cover Protect Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCEarlyCoverPrtctXprtnDt")]
    #endif
    [IsoXmlTag("DTCEarlyCoverPrtctXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? DTCEarlyCoverProtectExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? DTCEarlyCoverProtectExpirationDate { get; init; } 
    #else
    public DateFormat49Choice_? DTCEarlyCoverProtectExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// For Reorganization events, date at which instructions will be accepted by agent for payment.
    /// </summary>
    [IsoId("_CzLSv-2KEeiWtrflKsFqHg")]
    [DisplayName("Process To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcToDt")]
    #endif
    [IsoXmlTag("PrcToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ProcessToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ProcessToDate { get; init; } 
    #else
    public DateFormat49Choice_? ProcessToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which DTC expects to receive funds for distribution from the issuer / offeror.  It will be used before payout details are available.
    /// </summary>
    [IsoId("_ASDZwe2KEeiWtrflKsFqHg")]
    [DisplayName("DTC Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCEarlstPmtDt")]
    #endif
    [IsoXmlTag("DTCEarlstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DTCEarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DTCEarliestPaymentDate { get; init; } 
    #else
    public System.DateOnly? DTCEarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
