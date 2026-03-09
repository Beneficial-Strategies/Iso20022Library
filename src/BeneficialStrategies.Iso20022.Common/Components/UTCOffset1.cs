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
/// Specifies the parameters to calculate the local reporting time.
/// </summary>
[IsoId("_RKPjkNp-Ed-ak6NoX_4Aeg_-688976051")]
[DisplayName("UTC Offset")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UTCOffset1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UTCOffset1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UTCOffset1( System.String reqSign,System.TimeOnly reqNumberOfHours )
    {
        Sign = reqSign;
        NumberOfHours = reqNumberOfHours;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the offset is before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_RKPjkdp-Ed-ak6NoX_4Aeg_-597549067")]
    [DisplayName("Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgn")]
    #endif
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPlusOrMinusIndicator Sign { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Sign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Sign { get; init; } 
    #else
    public System.String Sign { get; set; } 
    #endif
    
    /// <summary>
    /// Offset of the reporting time, in hours, before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_RKPjktp-Ed-ak6NoX_4Aeg_-316800485")]
    [DisplayName("Number Of Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfHrs")]
    #endif
    [IsoXmlTag("NbOfHrs")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime NumberOfHours { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly NumberOfHours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly NumberOfHours { get; init; } 
    #else
    public System.TimeOnly NumberOfHours { get; set; } 
    #endif
    
    
    #nullable disable
    
}
