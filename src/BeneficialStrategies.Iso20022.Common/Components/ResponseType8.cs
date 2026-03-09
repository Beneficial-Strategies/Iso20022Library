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
/// Trace of response by the entities in the path from the issuer to the ATM.
/// </summary>
[IsoId("_QBsiAa1_EeWMg5rOByfExw")]
[DisplayName("Response Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponseType8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponseType8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponseType8( System.String reqResponderIdentification,System.String reqResponse )
    {
        ResponderIdentification = reqResponderIdentification;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the responder.
    /// </summary>
    [IsoId("_QNdtIa1_EeWMg5rOByfExw")]
    [DisplayName("Responder Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspndrId")]
    #endif
    [IsoXmlTag("RspndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ResponderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResponderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResponderIdentification { get; init; } 
    #else
    public System.String ResponderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the response (for instance ISO 8583, IFX).
    /// </summary>
    [IsoId("_QNdtI61_EeWMg5rOByfExw")]
    [DisplayName("Codification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdfctn")]
    #endif
    [IsoXmlTag("Cdfctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Codification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Codification { get; init; } 
    #else
    public System.String? Codification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the request.
    /// </summary>
    [IsoId("_QNdtJa1_EeWMg5rOByfExw")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Response { get; init; } 
    #else
    public System.String Response { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_QNdtJ61_EeWMg5rOByfExw")]
    [DisplayName("Response Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRsn")]
    #endif
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResponseReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseReason { get; init; } 
    #else
    public System.String? ResponseReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_QNdtKa1_EeWMg5rOByfExw")]
    [DisplayName("Additional Response Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRspnInf")]
    #endif
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalResponseInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalResponseInformation { get; init; } 
    #else
    public System.String? AdditionalResponseInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
