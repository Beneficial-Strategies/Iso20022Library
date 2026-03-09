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
/// Reason why the service is taxed.
/// </summary>
[IsoId("_6TrGE5qlEeGSON8vddiWzQ_2115552253")]
[DisplayName("Tax Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxReason1( System.String reqCode,System.String reqExplanation )
    {
        Code = reqCode;
        Explanation = reqExplanation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason why the service is taxed, in a coded form.
    /// </summary>
    [IsoId("_6TrGFJqlEeGSON8vddiWzQ_-393693755")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10Text Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Code { get; init; } 
    #else
    public System.String Code { get; set; } 
    #endif
    
    /// <summary>
    /// Reason why the service is taxed, in a free-text form.
    /// </summary>
    [IsoId("_6TrGFZqlEeGSON8vddiWzQ_887562025")]
    [DisplayName("Explanation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Expltn")]
    #endif
    [IsoXmlTag("Expltn")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text Explanation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Explanation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Explanation { get; init; } 
    #else
    public System.String Explanation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
