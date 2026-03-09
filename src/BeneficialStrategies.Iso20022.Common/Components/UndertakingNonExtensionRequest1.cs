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
/// Details of the non extension request.
/// </summary>
[IsoId("_-D6xxnltEeG7BsjMvd1mEw_-1432358339")]
[DisplayName("Undertaking Non Extension Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingNonExtensionRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingNonExtensionRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingNonExtensionRequest1( PartyIdentification43 reqRequestingParty,Undertaking9 reqUndertakingIdentification )
    {
        RequestingParty = reqRequestingParty;
        UndertakingIdentification = reqUndertakingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the requesting party.
    /// </summary>
    [IsoId("_-D6xx3ltEeG7BsjMvd1mEw_-452692672")]
    [DisplayName("Requesting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstngPty")]
    #endif
    [IsoXmlTag("RqstngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 RequestingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 RequestingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 RequestingParty { get; init; } 
    #else
    public PartyIdentification43 RequestingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-D6xyHltEeG7BsjMvd1mEw_747345040")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
