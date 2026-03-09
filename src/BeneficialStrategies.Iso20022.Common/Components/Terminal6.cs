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
/// Payment terminal or ATM performing the transaction
/// </summary>
[IsoId("_F0hq0RyrEey6gI8SKlv7rg")]
[DisplayName("Terminal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Terminal6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Terminal6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Terminal6( TerminalIdentification3 reqTerminalIdentification )
    {
        TerminalIdentification = reqTerminalIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_F6TisRyrEey6gI8SKlv7rg")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalIdentification3 TerminalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalIdentification3 TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalIdentification3 TerminalIdentification { get; init; } 
    #else
    public TerminalIdentification3 TerminalIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
