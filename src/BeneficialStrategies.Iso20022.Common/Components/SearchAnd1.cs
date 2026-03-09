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
/// List of criteria following the AND logic.
/// </summary>
[IsoId("_JdNs8N6QEeiwsev40qZGEQ")]
[DisplayName("Search And")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SearchAnd1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SearchAnd1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SearchAnd1( System.String reqTarget,Operator1Code reqOperator,System.String reqValue )
    {
        Target = reqTarget;
        Operator = reqOperator;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of target element.
    /// </summary>
    [IsoId("_Sh7OsN6QEeiwsev40qZGEQ")]
    [DisplayName("Target")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trgt")]
    #endif
    [IsoXmlTag("Trgt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax500Text Target { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Target { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Target { get; init; } 
    #else
    public System.String Target { get; set; } 
    #endif
    
    /// <summary>
    /// Comparison operator used to evaluate matching transactions vs criteria.
    /// </summary>
    [IsoId("_VruRMN6QEeiwsev40qZGEQ")]
    [DisplayName("Operator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprtr")]
    #endif
    [IsoXmlTag("Oprtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Operator1Code Operator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Operator1Code Operator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operator1Code Operator { get; init; } 
    #else
    public Operator1Code Operator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference value to be used when evaluating against the target element value using the criteria operator.
    /// </summary>
    [IsoId("_Y_OCQN6QEeiwsev40qZGEQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax500Text Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Value { get; init; } 
    #else
    public System.String Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
