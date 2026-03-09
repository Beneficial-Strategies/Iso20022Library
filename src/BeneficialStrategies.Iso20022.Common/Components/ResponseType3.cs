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
[IsoId("_15bm0YqCEeS3NqNpgnMh2w")]
[DisplayName("Response Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponseType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponseType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponseType3( Response4Code reqResponse )
    {
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of the requested transaction.
    /// </summary>
    [IsoId("_2FgT8YqCEeS3NqNpgnMh2w")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Response4Code Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Response4Code Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response4Code Response { get; init; } 
    #else
    public Response4Code Response { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_2FgT84qCEeS3NqNpgnMh2w")]
    [DisplayName("Response Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRsn")]
    #endif
    [IsoXmlTag("RspnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultDetail2Code? ResponseReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultDetail2Code? ResponseReason { get; init; } 
    #else
    public ResultDetail2Code? ResponseReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_2FgT9YqCEeS3NqNpgnMh2w")]
    [DisplayName("Additional Response Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRspnInf")]
    #endif
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalResponseInformation { get; init; } 
    #else
    public System.String? AdditionalResponseInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
