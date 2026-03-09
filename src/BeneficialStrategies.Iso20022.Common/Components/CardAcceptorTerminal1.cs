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
/// Payment terminal or ATM performing the transaction.
/// </summary>
[IsoId("_Yqs_gHrvEeSz_of_1TY14A")]
[DisplayName("Card Acceptor Terminal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAcceptorTerminal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardAcceptorTerminal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardAcceptorTerminal1( GenericIdentification32 reqIdentification,PointOfInteractionCapabilities4 reqCapabilities )
    {
        Identification = reqIdentification;
        Capabilities = reqCapabilities;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal. 
    /// It correspond to the ISO 8583 field number 41.
    /// </summary>
    [IsoId("_DxCzkHrwEeSz_of_1TY14A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 Identification { get; init; } 
    #else
    public GenericIdentification32 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the terminal.
    /// </summary>
    [IsoId("_ICRYMHrwEeSz_of_1TY14A")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress18? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress18? Location { get; init; } 
    #else
    public PostalAddress18? Location { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_NqmSoHrwEeSz_of_1TY14A")]
    [DisplayName("Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpblties")]
    #endif
    [IsoXmlTag("Cpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteractionCapabilities4 Capabilities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteractionCapabilities4 Capabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities4 Capabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities4 Capabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
