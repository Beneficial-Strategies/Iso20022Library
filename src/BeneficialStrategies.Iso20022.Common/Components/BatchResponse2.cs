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
/// Content of the Batch Response message.
/// </summary>
[IsoId("_zr0G8QxrEeqdx6buGpCCQw")]
[DisplayName("Batch Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BatchResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_z2qFAQxrEeqdx6buGpCCQw")]
    [DisplayName("Performed Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfrmdTx")]
    #endif
    [IsoXmlTag("PrfrmdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PerformedTransaction2? PerformedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PerformedTransaction2? PerformedTransaction { get; init; } 
    #else
    public PerformedTransaction2? PerformedTransaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
