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
/// Replacement of an existing content by a different one.
/// </summary>
[IsoId("_UtfA1dp-Ed-ak6NoX_4Aeg_1630860927")]
[DisplayName("Replacement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Replacement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Replacement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Replacement1( System.String reqCurrentValue,System.String reqProposedValue )
    {
        CurrentValue = reqCurrentValue;
        ProposedValue = reqProposedValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of the current element.
    /// </summary>
    [IsoId("_UtfA1tp-Ed-ak6NoX_4Aeg_2072304256")]
    [DisplayName("Current Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurVal")]
    #endif
    [IsoXmlTag("CurVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text CurrentValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CurrentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CurrentValue { get; init; } 
    #else
    public System.String CurrentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the new element.
    /// </summary>
    [IsoId("_UtfA19p-Ed-ak6NoX_4Aeg_2072304711")]
    [DisplayName("Proposed Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdVal")]
    #endif
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text ProposedValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProposedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProposedValue { get; init; } 
    #else
    public System.String ProposedValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
