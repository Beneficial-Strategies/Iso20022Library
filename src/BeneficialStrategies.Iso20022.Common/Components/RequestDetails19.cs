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
/// Details of the processing request.
/// </summary>
[IsoId("_qWuLAZXcEeaYkf5FCqYMeA")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails19( System.String reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_qh5gQZXcEeaYkf5FCqYMeA")]
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
    /// Identificates the requestor.
    /// </summary>
    [IsoId("_qh5gQ5XcEeaYkf5FCqYMeA")]
    [DisplayName("Requestor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstrId")]
    #endif
    [IsoXmlTag("RqstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? RequestorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? RequestorIdentification { get; init; } 
    #else
    public PartyIdentification73Choice_? RequestorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to support the processing request.
    /// </summary>
    [IsoId("_gaPZ0JwpEeahw7LV9elg3w")]
    [DisplayName("Additional Request Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlReqInf")]
    #endif
    [IsoXmlTag("AddtlReqInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalRequestInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalRequestInformation { get; init; } 
    #else
    public System.String? AdditionalRequestInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
