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
/// Report of the requested data.
/// </summary>
[IsoId("_SumZGwEcEeCQm6a_G2yO_w_1103821784")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails5( System.String reqType,System.String reqRequestReference )
    {
        Type = reqType;
        RequestReference = reqRequestReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_SuwKEAEcEeCQm6a_G2yO_w_1937892344")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the request for which the report is sent.
    /// </summary>
    [IsoId("_SuwKEQEcEeCQm6a_G2yO_w_-179622077")]
    [DisplayName("Request Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRef")]
    #endif
    [IsoXmlTag("ReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RequestReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestReference { get; init; } 
    #else
    public System.String RequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Report key and returned data.
    /// </summary>
    [IsoId("_SuwKEgEcEeCQm6a_G2yO_w_1731831000")]
    [DisplayName("Report Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptKey")]
    #endif
    [IsoXmlTag("RptKey")]
    public ValueList<RequestDetails4> ReportKey { get; init; } = new ValueList<RequestDetails4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SuwKEgEcEeCQm6a_G2yO_w_1731831000
    
    
    #nullable disable
    
}
