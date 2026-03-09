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
/// Information about a discrepancy of a demand.
/// </summary>
[IsoId("_-BiMJnltEeG7BsjMvd1mEw_711014268")]
[DisplayName("Discrepancy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Discrepancy1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Discrepancy1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Discrepancy1( System.String reqIdentification,System.String reqNarrative )
    {
        Identification = reqIdentification;
        Narrative = reqNarrative;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the discrepancy.
    /// </summary>
    [IsoId("_-BiMJ3ltEeG7BsjMvd1mEw_170785768")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the discrepancy.
    /// </summary>
    [IsoId("_-BiMKXltEeG7BsjMvd1mEw_-2015726895")]
    [DisplayName("Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nrrtv")]
    #endif
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20000Text Narrative { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Narrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Narrative { get; init; } 
    #else
    public System.String Narrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
