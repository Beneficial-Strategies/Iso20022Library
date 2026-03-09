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
/// Financial instrument stressed under a stress test scenario.
/// </summary>
[IsoId("_DU0dAas2Eeayv9XxdmMwKQ")]
[DisplayName("Stressed Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StressedProduct1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StressedProduct1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StressedProduct1( GenericIdentification168 reqIdentification,StressSize1Choice_ reqMaximumStressSize,StressSize1Choice_ reqMinimumStressSize )
    {
        Identification = reqIdentification;
        MaximumStressSize = reqMaximumStressSize;
        MinimumStressSize = reqMinimumStressSize;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the product.
    /// </summary>
    [IsoId("_De8CU6s2Eeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168 Identification { get; init; } 
    #else
    public GenericIdentification168 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum move across the curve for the stressed product.
    /// </summary>
    [IsoId("_Je6nwKs2Eeayv9XxdmMwKQ")]
    [DisplayName("Maximum Stress Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxStrssSz")]
    #endif
    [IsoXmlTag("MaxStrssSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StressSize1Choice_ MaximumStressSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StressSize1Choice_ MaximumStressSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StressSize1Choice_ MaximumStressSize { get; init; } 
    #else
    public StressSize1Choice_ MaximumStressSize { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum move across the curve for the stressed product.
    /// </summary>
    [IsoId("_ect90HeOEee4S4mjz5XBYA")]
    [DisplayName("Minimum Stress Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinStrssSz")]
    #endif
    [IsoXmlTag("MinStrssSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StressSize1Choice_ MinimumStressSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StressSize1Choice_ MinimumStressSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StressSize1Choice_ MinimumStressSize { get; init; } 
    #else
    public StressSize1Choice_ MinimumStressSize { get; set; } 
    #endif
    
    
    #nullable disable
    
}
