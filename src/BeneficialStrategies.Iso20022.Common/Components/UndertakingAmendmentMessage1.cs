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
/// Contents of an Undertaking Amendment message.
/// </summary>
[IsoId("_98eF8nltEeG7BsjMvd1mEw_1389753684")]
[DisplayName("Undertaking Amendment Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmendmentMessage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmendmentMessage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmendmentMessage1( Amendment1 reqUndertakingAmendmentDetails )
    {
        UndertakingAmendmentDetails = reqUndertakingAmendmentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the proposed undertaking amendment.
    /// </summary>
    [IsoId("_98eF83ltEeG7BsjMvd1mEw_214562659")]
    [DisplayName("Undertaking Amendment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntDtls")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment1 UndertakingAmendmentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amendment1 UndertakingAmendmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment1 UndertakingAmendmentDetails { get; init; } 
    #else
    public Amendment1 UndertakingAmendmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the proposed amendment.
    /// </summary>
    [IsoId("_98eF9HltEeG7BsjMvd1mEw_1737562986")]
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
