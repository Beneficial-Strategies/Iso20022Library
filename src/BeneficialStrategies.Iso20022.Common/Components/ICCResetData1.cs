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
/// Data of a Chip Card related to the reset of the chip.
/// </summary>
[IsoId("_SNfVUN7IEeiwsev40qZGEQ")]
[DisplayName("ICC Reset Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ICCResetData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the Answer To Reset of a chip card.
    /// </summary>
    [IsoId("_ZUB6MN7IEeiwsev40qZGEQ")]
    [DisplayName("ATR Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATRVal")]
    #endif
    [IsoXmlTag("ATRVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? ATRValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ATRValue { get; init; } 
    #else
    public System.Byte[]? ATRValue { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2).
    /// </summary>
    [IsoId("_dbA9sN7IEeiwsev40qZGEQ")]
    [DisplayName("Card Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardSts")]
    #endif
    [IsoXmlTag("CardSts")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? CardStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? CardStatus { get; init; } 
    #else
    public System.Byte[]? CardStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
