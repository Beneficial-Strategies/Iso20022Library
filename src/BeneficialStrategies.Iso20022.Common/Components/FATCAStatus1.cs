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
/// Foreign Account Tax Compliance Act (FATCA) status information.
/// </summary>
[IsoId("_hc90MQjREeS5F6qHcKOrew")]
[DisplayName("FATCA Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FATCAStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FATCAStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FATCAStatus1( FATCAStatus1Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_o1L-8AjREeS5F6qHcKOrew")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FATCAStatus1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FATCAStatus1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FATCAStatus1Choice_ Type { get; init; } 
    #else
    public FATCAStatus1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_thIJoAjREeS5F6qHcKOrew")]
    [DisplayName("Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Src")]
    #endif
    [IsoXmlTag("Src")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FATCASource1Choice_? Source { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FATCASource1Choice_? Source { get; init; } 
    #else
    public FATCASource1Choice_? Source { get; set; } 
    #endif
    
    
    #nullable disable
    
}
