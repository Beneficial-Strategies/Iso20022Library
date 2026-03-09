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
/// Defines the intra-balance movement status query criteria including the status period.
/// </summary>
[IsoId("_Vp21kTp9EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceQueryStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalanceQueryStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceQueryStatus3( IntraBalanceStatusType2 reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the status type of query criteria.
    /// </summary>
    [IsoId("_V0R84Tp9EemwKdP955WBJQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraBalanceStatusType2 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraBalanceStatusType2 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalanceStatusType2 Type { get; init; } 
    #else
    public IntraBalanceStatusType2 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specified date period of the status.
    /// </summary>
    [IsoId("_V0R84zp9EemwKdP955WBJQ")]
    [DisplayName("Date Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtPrd")]
    #endif
    [IsoXmlTag("DtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch5Choice_? DatePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch5Choice_? DatePeriod { get; init; } 
    #else
    public DateAndDateTimeSearch5Choice_? DatePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
