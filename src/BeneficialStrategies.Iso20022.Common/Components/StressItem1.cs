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
/// Risk factor, financial instrument or set of financial instruments that is stressed under a hypothetical stress scenario.
/// </summary>
[IsoId("_0AzLQKszEeayv9XxdmMwKQ")]
[DisplayName("Stress Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StressItem1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StressItem1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StressItem1( StressItem1Choice_ reqStressProduct )
    {
        StressProduct = reqStressProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of information relating to major representative product being stressed under the stress scenario.
    /// </summary>
    [IsoId("_70-SMKszEeayv9XxdmMwKQ")]
    [DisplayName("Stress Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrssPdct")]
    #endif
    [IsoXmlTag("StrssPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StressItem1Choice_ StressProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StressItem1Choice_ StressProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StressItem1Choice_ StressProduct { get; init; } 
    #else
    public StressItem1Choice_ StressProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
