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
/// Information about an innovative finance product.
/// </summary>
[IsoId("_lM8GQE7bEeifNrXGwadPmg")]
[DisplayName("Innovative Finance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InnovativeFinance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InnovativeFinance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InnovativeFinance1( GenericIdentification36 reqType,System.String reqInformation )
    {
        Type = reqType;
        Information = reqInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of innovative finance product.
    /// </summary>
    [IsoId("_nqMy4E7bEeifNrXGwadPmg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification36 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification36 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36 Type { get; init; } 
    #else
    public GenericIdentification36 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Details of an innovative finance product.
    /// </summary>
    [IsoId("_rBLVwE7bEeifNrXGwadPmg")]
    [DisplayName("Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Inf")]
    #endif
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Information { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Information { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Information { get; init; } 
    #else
    public System.String Information { get; set; } 
    #endif
    
    
    #nullable disable
    
}
