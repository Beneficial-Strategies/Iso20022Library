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
/// Card writing capability of the terminal performing the transaction.
/// </summary>
[IsoId("_BQxRQTEvEeyjbpgZW6G1Fg")]
[DisplayName("Card Writing Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardWritingCapabilities1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardWritingCapabilities1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardWritingCapabilities1( CardDataWriting1Code reqCapability )
    {
        Capability = reqCapability;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Card writing capability of the terminal performing the transaction.
    /// </summary>
    [IsoId("_BWRcUTEvEeyjbpgZW6G1Fg")]
    [DisplayName("Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpblty")]
    #endif
    [IsoXmlTag("Cpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardDataWriting1Code Capability { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardDataWriting1Code Capability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataWriting1Code Capability { get; init; } 
    #else
    public CardDataWriting1Code Capability { get; set; } 
    #endif
    
    /// <summary>
    /// Other types of card data writing capabilities.
    /// </summary>
    [IsoId("_BWRcXzEvEeyjbpgZW6G1Fg")]
    [DisplayName("Other Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCpblty")]
    #endif
    [IsoXmlTag("OthrCpblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherCapability { get; init; } 
    #else
    public System.String? OtherCapability { get; set; } 
    #endif
    
    
    #nullable disable
    
}
