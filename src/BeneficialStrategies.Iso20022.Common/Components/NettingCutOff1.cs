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
/// Provides the details for one to many netting cut off update requests to be actioned by a central system.
/// </summary>
[IsoId("_3VEsgJVHEeaYkf5FCqYMeA")]
[DisplayName("Netting Cut Off")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NettingCutOff1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NettingCutOff1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NettingCutOff1( NettingIdentification1Choice_ reqNettingIdentification )
    {
        NettingIdentification = reqNettingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the netting party or group.
    /// </summary>
    [IsoId("_lQffwJXWEeaYkf5FCqYMeA")]
    [DisplayName("Netting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgId")]
    #endif
    [IsoXmlTag("NetgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingIdentification1Choice_ NettingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingIdentification1Choice_ NettingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingIdentification1Choice_ NettingIdentification { get; init; } 
    #else
    public NettingIdentification1Choice_ NettingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_JpSG4JVMEeaYkf5FCqYMeA")]
    [DisplayName("New Cut Off")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewCutOff")]
    #endif
    [IsoXmlTag("NewCutOff")]
    public ValueList<CutOff1> NewCutOff { get; init; } = new ValueList<CutOff1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _JpSG4JVMEeaYkf5FCqYMeA
    
    
    #nullable disable
    
}
