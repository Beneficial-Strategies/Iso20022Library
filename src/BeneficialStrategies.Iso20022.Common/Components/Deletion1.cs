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
/// Deletion of the current element.
/// </summary>
[IsoId("_UtVP1tp-Ed-ak6NoX_4Aeg_1632709893")]
[DisplayName("Deletion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Deletion1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Deletion1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Deletion1( System.String reqDeletedValue )
    {
        DeletedValue = reqDeletedValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of the deleted element.
    /// </summary>
    [IsoId("_UtVP19p-Ed-ak6NoX_4Aeg_2107399666")]
    [DisplayName("Deleted Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeltdVal")]
    #endif
    [IsoXmlTag("DeltdVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text DeletedValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DeletedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DeletedValue { get; init; } 
    #else
    public System.String DeletedValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
