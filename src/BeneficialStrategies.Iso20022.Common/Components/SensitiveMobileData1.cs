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
/// Sensitive information related to the mobile phone.
/// </summary>
[IsoId("_U6ri8NtoEeipuvJHTHIw9A")]
[DisplayName("Sensitive Mobile Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SensitiveMobileData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SensitiveMobileData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SensitiveMobileData1( System.String reqMSISDN )
    {
        MSISDN = reqMSISDN;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// identifies the mobile - Mobile Subscriber Integrated Service Digital Network (The SIM identifier).
    /// </summary>
    [IsoId("_q4gFINtoEeipuvJHTHIw9A")]
    [DisplayName("MSISDN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MSISDN")]
    #endif
    [IsoXmlTag("MSISDN")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35NumericText MSISDN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MSISDN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MSISDN { get; init; } 
    #else
    public System.String MSISDN { get; set; } 
    #endif
    
    /// <summary>
    /// International Mobile Subscriber Identity is a unique number associated with the mobile phone user, containing the Mobile Country Code (MCC), the Mobile Network Code (MNC), and the Mobile Identification Number (MSIN).
    /// </summary>
    [IsoId("_w87FsNtoEeipuvJHTHIw9A")]
    [DisplayName("IMSI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IMSI")]
    #endif
    [IsoXmlTag("IMSI")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? IMSI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IMSI { get; init; } 
    #else
    public System.String? IMSI { get; set; } 
    #endif
    
    /// <summary>
    /// International Mobile Equipment Identity is a number usually unique to identify a mobile phone.
    /// </summary>
    [IsoId("_1pDdoNtoEeipuvJHTHIw9A")]
    [DisplayName("IMEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IMEI")]
    #endif
    [IsoXmlTag("IMEI")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? IMEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IMEI { get; init; } 
    #else
    public System.String? IMEI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
