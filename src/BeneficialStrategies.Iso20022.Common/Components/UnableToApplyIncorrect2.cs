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
/// Specifies the details of incorrect information.
/// </summary>
[IsoId("_-C21gdjKEeq5MfBBxQig1Q")]
[DisplayName("Unable To Apply Incorrect")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnableToApplyIncorrect2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnableToApplyIncorrect2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnableToApplyIncorrect2( IncorrectData1Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies which data type is incorrect in the transaction.
    /// </summary>
    [IsoId("_-FWv49jKEeq5MfBBxQig1Q")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IncorrectData1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IncorrectData1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncorrectData1Choice_ Type { get; init; } 
    #else
    public IncorrectData1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Further details about the incorrect information.
    /// </summary>
    [IsoId("_-FWv5djKEeq5MfBBxQig1Q")]
    [DisplayName("Additional Incorrect Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlIncrrctInf")]
    #endif
    [IsoXmlTag("AddtlIncrrctInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalIncorrectInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalIncorrectInformation { get; init; } 
    #else
    public System.String? AdditionalIncorrectInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
