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
/// U-003-2009 Addition and Modification of choice component. S-009-2009 They are not valid business options in the redemption processing context. S-015-2009 Add new data elements to indicate time zone.
/// </summary>
[IsoId("_SsJbPdp-Ed-ak6NoX_4Aeg_2033258756")]
[DisplayName("Main Fund Order Desk Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MainFundOrderDeskLocation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MainFundOrderDeskLocation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MainFundOrderDeskLocation1( string reqCountry,UTCOffset1 reqTimeZoneOffSet )
    {
        Country = reqCountry;
        TimeZoneOffSet = reqTimeZoneOffSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country in which it is authorised to commercialise the fund.
    /// </summary>
    [IsoId("_SsJbPtp-Ed-ak6NoX_4Aeg_1855465345")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Offset of the reporting time before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_SsJbP9p-Ed-ak6NoX_4Aeg_-559851982")]
    [DisplayName("Time Zone Off Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmZoneOffSet")]
    #endif
    [IsoXmlTag("TmZoneOffSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UTCOffset1 TimeZoneOffSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UTCOffset1 TimeZoneOffSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UTCOffset1 TimeZoneOffSet { get; init; } 
    #else
    public UTCOffset1 TimeZoneOffSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
