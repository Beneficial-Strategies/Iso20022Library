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
/// Contents of an UndertakingAmendmentResponse message.
/// </summary>
[IsoId("_98n283ltEeG7BsjMvd1mEw_1014525589")]
[DisplayName("Undertaking Amendment Response Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmendmentResponseMessage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmendmentResponseMessage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmendmentResponseMessage1( Amendment7 reqUndertakingAmendmentResponseDetails )
    {
        UndertakingAmendmentResponseDetails = reqUndertakingAmendmentResponseDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the proposed amendment response.
    /// </summary>
    [IsoId("_98xA4XltEeG7BsjMvd1mEw_-1912411864")]
    [DisplayName("Undertaking Amendment Response Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntRspnDtls")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntRspnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    #else
    public Amendment7 UndertakingAmendmentResponseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    [IsoId("_ASLHQ387EeGx884K2iQOLg")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
