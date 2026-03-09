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
/// Details of one or several keys of the request.
/// </summary>
[IsoId("_SuwKFgEcEeCQm6a_G2yO_w_-1482671344")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails4( System.String reqKey )
    {
        Key = reqKey;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Key for which the specific data is returned, for example, a BIC.
    /// </summary>
    [IsoId("_SuwKFwEcEeCQm6a_G2yO_w_1787384874")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Key { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Key { get; init; } 
    #else
    public System.String Key { get; set; } 
    #endif
    
    /// <summary>
    /// Data being returned.
    /// </summary>
    [IsoId("_SuwKGAEcEeCQm6a_G2yO_w_-56014594")]
    [DisplayName("Report Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptData")]
    #endif
    [IsoXmlTag("RptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportParameter1? ReportData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameter1? ReportData { get; init; } 
    #else
    public ReportParameter1? ReportData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
