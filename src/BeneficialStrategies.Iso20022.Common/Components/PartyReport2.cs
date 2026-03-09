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
/// Report information about party reference data.
/// </summary>
[IsoId("_enGS1fAzEeWPfa2xBhBfLQ")]
[DisplayName("Party Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyReport2( SystemPartyIdentification3 reqPartyIdentification,PartyOrBusinessError2Choice_ reqPartyOrError )
    {
        PartyIdentification = reqPartyIdentification;
        PartyOrError = reqPartyOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_ewUgQfAzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification3 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification3 PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification3 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    [IsoId("_ewUgQ_AzEeWPfa2xBhBfLQ")]
    [DisplayName("Party Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyOrErr")]
    #endif
    [IsoXmlTag("PtyOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyOrBusinessError2Choice_ PartyOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyOrBusinessError2Choice_ PartyOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyOrBusinessError2Choice_ PartyOrError { get; init; } 
    #else
    public PartyOrBusinessError2Choice_ PartyOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
