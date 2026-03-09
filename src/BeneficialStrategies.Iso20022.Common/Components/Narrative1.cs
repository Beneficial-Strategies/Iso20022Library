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
/// Narrative information for an undertaking.
/// </summary>
[IsoId("_94mSknltEeG7BsjMvd1mEw_1059061696")]
[DisplayName("Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Narrative1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of term or condition.
    /// </summary>
    [IsoId("_94mSk3ltEeG7BsjMvd1mEw_860460142")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NarrativeType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NarrativeType1Choice_? Type { get; init; } 
    #else
    public NarrativeType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Narrative text.
    /// </summary>
    [IsoId("_94mSlHltEeG7BsjMvd1mEw_-1855880326")]
    [DisplayName("Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txt")]
    #endif
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [MinLength(1)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
