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
/// Communication details related to the registered currency control contract.
/// </summary>
[IsoId("_oDuGMdL6EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Communication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContractCommunication1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContractCommunication1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContractCommunication1( CommunicationMethod4Code reqMethod,System.DateOnly reqDate )
    {
        Method = reqMethod;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method by which the registered contract document is exchanged.
    /// </summary>
    [IsoId("_t3zksNL6EeSDLevdaFPXHw")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationMethod4Code Method { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationMethod4Code Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationMethod4Code Method { get; init; } 
    #else
    public CommunicationMethod4Code Method { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the exchange.
    /// </summary>
    [IsoId("_8MZrsNL6EeSDLevdaFPXHw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    
    #nullable disable
    
}
