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
/// Details of the instructions from the bank.
/// </summary>
[IsoId("_-E96onltEeG7BsjMvd1mEw_-1962266357")]
[DisplayName("Bank Instructions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankInstructions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Instructions from the bank.
    /// </summary>
    [IsoId("_-E96o3ltEeG7BsjMvd1mEw_-327246160")]
    [DisplayName("Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txt")]
    #endif
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Last date for a response to the bank instructions.
    /// </summary>
    [IsoId("_-E96pHltEeG7BsjMvd1mEw_878374168")]
    [DisplayName("Last Date For Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastDtForRspn")]
    #endif
    [IsoXmlTag("LastDtForRspn")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastDateForResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastDateForResponse { get; init; } 
    #else
    public System.DateOnly? LastDateForResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
