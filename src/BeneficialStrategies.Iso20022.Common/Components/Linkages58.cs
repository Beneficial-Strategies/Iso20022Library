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
/// Information related to a linked transaction.
/// </summary>
[IsoId("_3zSo0FSDEemTt7251YwCKw")]
[DisplayName("Linkages")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages58
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages58 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages58( References70Choice_ reqReferences )
    {
        References = reqReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_cb45MFSLEemTt7251YwCKw")]
    [DisplayName("Message Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNb")]
    #endif
    [IsoXmlTag("MsgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber5Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the linked transaction or instruction.
    /// </summary>
    [IsoId("_x_BDcFSLEemTt7251YwCKw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References70Choice_ References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References70Choice_ References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References70Choice_ References { get; init; } 
    #else
    public References70Choice_ References { get; set; } 
    #endif
    
    
    #nullable disable
    
}
