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
[IsoId("_RbYW4tp-Ed-ak6NoX_4Aeg_65619954")]
[DisplayName("Replacement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Replacement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Replacement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Replacement2( System.String reqCurrentValue,System.String reqProposedValue )
    {
        CurrentValue = reqCurrentValue;
        ProposedValue = reqProposedValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of the current element.
    /// </summary>
    [IsoId("_RbYW49p-Ed-ak6NoX_4Aeg_65620232")]
    [DisplayName("Current Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurVal")]
    #endif
    [IsoXmlTag("CurVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text CurrentValue { get; init; } 
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
    [IsoId("_RbYW5Np-Ed-ak6NoX_4Aeg_65620263")]
    [DisplayName("Proposed Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdVal")]
    #endif
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text ProposedValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProposedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProposedValue { get; init; } 
    #else
    public System.String ProposedValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
