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
/// Presence condition of a message item.
/// </summary>
[IsoId("_NEF-EXDxEe2MCaKO5AtGsA")]
[DisplayName("Message Item Condition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageItemCondition2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageItemCondition2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageItemCondition2( System.String reqItemIdentification,MessageItemCondition2Code reqCondition )
    {
        ItemIdentification = reqItemIdentification;
        Condition = reqCondition;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the message and the message item.
    /// </summary>
    [IsoId("_NLeYcXDxEe2MCaKO5AtGsA")]
    [DisplayName("Item Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmId")]
    #endif
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text ItemIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ItemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ItemIdentification { get; init; } 
    #else
    public System.String ItemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Condition of presence of the message item.
    /// </summary>
    [IsoId("_NLeYc3DxEe2MCaKO5AtGsA")]
    [DisplayName("Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond")]
    #endif
    [IsoXmlTag("Cond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageItemCondition2Code Condition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageItemCondition2Code Condition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageItemCondition2Code Condition { get; init; } 
    #else
    public MessageItemCondition2Code Condition { get; set; } 
    #endif
    
    /// <summary>
    /// Value to be used for the message item.
    /// </summary>
    [IsoId("_NLeYdXDxEe2MCaKO5AtGsA")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Value { get; init; } 
    #else
    public System.String? Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
