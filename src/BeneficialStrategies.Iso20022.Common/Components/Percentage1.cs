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
/// Rate information.
/// </summary>
[IsoId("_99Ei5nltEeG7BsjMvd1mEw_171384620")]
[DisplayName("Percentage")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Percentage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Percentage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Percentage1( System.Decimal reqRate,ExternalRelativeTo1Code reqRelativeTo )
    {
        Rate = reqRate;
        RelativeTo = reqRelativeTo;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Percentage of an amount.
    /// </summary>
    [IsoId("_99Ei53ltEeG7BsjMvd1mEw_-1531427799")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of what the percentage is relative to.
    /// </summary>
    [IsoId("_99Ei6HltEeG7BsjMvd1mEw_880195488")]
    [DisplayName("Relative To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltvTo")]
    #endif
    [IsoXmlTag("RltvTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalRelativeTo1Code RelativeTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalRelativeTo1Code RelativeTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRelativeTo1Code RelativeTo { get; init; } 
    #else
    public ExternalRelativeTo1Code RelativeTo { get; set; } 
    #endif
    
    
    #nullable disable
    
}
