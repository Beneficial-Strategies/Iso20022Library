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
/// Response of a requested service.
/// </summary>
[IsoId("_BGwWoY4YEeW6h7rGyYlyTg")]
[DisplayName("Response Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponseType6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponseType6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponseType6( Response2Code reqResponse )
    {
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Response of the terminal manager.
    /// </summary>
    [IsoId("_BRMFAY4YEeW6h7rGyYlyTg")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Response2Code Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Response2Code Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response2Code Response { get; init; } 
    #else
    public Response2Code Response { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_BRMFA44YEeW6h7rGyYlyTg")]
    [DisplayName("Response Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDtl")]
    #endif
    [IsoXmlTag("RspnDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultDetail3Code? ResponseDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultDetail3Code? ResponseDetail { get; init; } 
    #else
    public ResultDetail3Code? ResponseDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the response for further examination.
    /// </summary>
    [IsoId("_BRMFBY4YEeW6h7rGyYlyTg")]
    [DisplayName("Additional Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRspn")]
    #endif
    [IsoXmlTag("AddtlRspn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalResponse { get; init; } 
    #else
    public System.String? AdditionalResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
