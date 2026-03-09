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
/// Specifies the opening and valuation conditions for the non deliverable forward.
/// </summary>
[IsoId("_dPfNQaZqEea16Jw8SEVrDQ")]
[DisplayName("Non Deliverable Forward Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonDeliverableForwardConditions2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonDeliverableForwardConditions2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonDeliverableForwardConditions2( OpeningConditions1 reqOpeningConditions )
    {
        OpeningConditions = reqOpeningConditions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the opening information associated with an NDF trade.
    /// </summary>
    [IsoId("_3xWiYKZqEea16Jw8SEVrDQ")]
    [DisplayName("Opening Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngConds")]
    #endif
    [IsoXmlTag("OpngConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OpeningConditions1 OpeningConditions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OpeningConditions1 OpeningConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningConditions1 OpeningConditions { get; init; } 
    #else
    public OpeningConditions1 OpeningConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the additional information for an NDF as supplied on a fixing instruction.
    /// </summary>
    [IsoId("_9vbDUKZqEea16Jw8SEVrDQ")]
    [DisplayName("Fixing Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxgConds")]
    #endif
    [IsoXmlTag("FxgConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FixingConditions1? FixingConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FixingConditions1? FixingConditions { get; init; } 
    #else
    public FixingConditions1? FixingConditions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
