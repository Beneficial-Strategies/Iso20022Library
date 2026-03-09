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
/// Data used to assign specific condition such as liability shift or preferential interchange fees.
/// </summary>
[IsoId("_02aBcHsJEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Condition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionCondition1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionCondition1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionCondition1( System.String reqProgram )
    {
        Program = reqProgram;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the specific condition.
    /// </summary>
    [IsoId("_DtntUHsKEeSR68OJvMfxJQ")]
    [DisplayName("Program")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prgm")]
    #endif
    [IsoXmlTag("Prgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Program { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Program { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Program { get; init; } 
    #else
    public System.String Program { get; set; } 
    #endif
    
    /// <summary>
    /// Level of the condition.
    /// </summary>
    [IsoId("_H8loIHsKEeSR68OJvMfxJQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Value { get; init; } 
    #else
    public System.String? Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
