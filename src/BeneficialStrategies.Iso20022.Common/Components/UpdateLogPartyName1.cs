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
/// Specifies the old and new values for the name of a party.
/// </summary>
[IsoId("_zOmJYGjVEeiRg5NzP0jkQg")]
[DisplayName("Update Log Party Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdateLogPartyName1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UpdateLogPartyName1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UpdateLogPartyName1( PartyName4 reqOld,PartyName4 reqNew )
    {
        Old = reqOld;
        New = reqNew;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_zOmJYWjVEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Od")]
    #endif
    [IsoXmlTag("Od")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyName4 Old { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyName4 Old { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyName4 Old { get; init; } 
    #else
    public PartyName4 Old { get; set; } 
    #endif
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_zOmJYmjVEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="New")]
    #endif
    [IsoXmlTag("New")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyName4 New { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyName4 New { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyName4 New { get; init; } 
    #else
    public PartyName4 New { get; set; } 
    #endif
    
    
    #nullable disable
    
}
