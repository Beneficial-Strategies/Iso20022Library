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
/// Fees not included in the transaction.
/// </summary>
[IsoId("_mFHMkESLEeeb1MmUPTrSMw")]
[DisplayName("Additional Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalFee1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalFee1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalFee1( TypeOfAmount10Code reqType,FeeAmount2 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    [IsoId("_1pF31ESLEeeb1MmUPTrSMw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount10Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount10Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount10Code Type { get; init; } 
    #else
    public TypeOfAmount10Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    [IsoId("_1pF31USLEeeb1MmUPTrSMw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of fee program.
    /// </summary>
    [IsoId("_7lgj8WqBEemXfKijhrqa-Q")]
    [DisplayName("Fee Program")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeePrgm")]
    #endif
    [IsoXmlTag("FeePrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FeeProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FeeProgram { get; init; } 
    #else
    public System.String? FeeProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    [IsoId("_8a_acWqBEemXfKijhrqa-Q")]
    [DisplayName("Fee Descriptor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeDscrptr")]
    #endif
    [IsoXmlTag("FeeDscrptr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FeeDescriptor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FeeDescriptor { get; init; } 
    #else
    public System.String? FeeDescriptor { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    [IsoId("_1pF31kSLEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FeeAmount2 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FeeAmount2 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FeeAmount2 Amount { get; init; } 
    #else
    public FeeAmount2 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    [IsoId("_wsUqAZmJEee_M7tURHTZTQ")]
    [DisplayName("Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labl")]
    #endif
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Label { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Label { get; init; } 
    #else
    public System.String? Label { get; set; } 
    #endif
    
    
    #nullable disable
    
}
