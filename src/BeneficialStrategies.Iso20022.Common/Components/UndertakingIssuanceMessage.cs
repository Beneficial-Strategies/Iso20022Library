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
/// Contents of the related UndertakingIssuance message or of the related issuance document.
/// </summary>
[IsoId("_98U8CHltEeG7BsjMvd1mEw_1927881342")]
[DisplayName("Undertaking Issuance Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingIssuanceMessage
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingIssuanceMessage instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingIssuanceMessage( Undertaking3 reqUndertakingDetails )
    {
        UndertakingDetails = reqUndertakingDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_98eF8HltEeG7BsjMvd1mEw_-650001851")]
    [DisplayName("Undertaking Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgDtls")]
    #endif
    [IsoXmlTag("UdrtkgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking3 UndertakingDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking3 UndertakingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking3 UndertakingDetails { get; init; } 
    #else
    public Undertaking3 UndertakingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the issued undertaking.
    /// </summary>
    [IsoId("_98eF8XltEeG7BsjMvd1mEw_410132243")]
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
