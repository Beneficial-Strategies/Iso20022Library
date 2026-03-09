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
/// Provides the details of the identification data that is requested to be verified.
/// </summary>
[IsoId("_fevvsdcZEeqRFcf2R4bPBw")]
[DisplayName("Identification Verification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationVerification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IdentificationVerification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IdentificationVerification4( System.String reqIdentification,IdentificationInformation4 reqPartyAndAccountIdentification )
    {
        Identification = reqIdentification;
        PartyAndAccountIdentification = reqPartyAndAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_fgQyo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party and/or account identification information for which verification is requested.
    /// </summary>
    [IsoId("_fgQypdcZEeqRFcf2R4bPBw")]
    [DisplayName("Party And Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyAndAcctId")]
    #endif
    [IsoXmlTag("PtyAndAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationInformation4 PartyAndAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationInformation4 PartyAndAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationInformation4 PartyAndAccountIdentification { get; init; } 
    #else
    public IdentificationInformation4 PartyAndAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
