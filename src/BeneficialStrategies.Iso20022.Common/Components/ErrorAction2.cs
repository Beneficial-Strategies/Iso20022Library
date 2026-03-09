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
/// Action to perform in case of error on the related action in progress.
/// </summary>
[IsoId("_FeJ-kR3ZEeKKrOIoqWglDw")]
[DisplayName("Error Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ErrorAction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ErrorAction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ErrorAction2( TerminalManagementErrorAction2Code reqActionToProcess )
    {
        ActionToProcess = reqActionToProcess;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    [IsoId("_FqWngR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnRslt")]
    #endif
    [IsoXmlTag("ActnRslt")]
    public SimpleValueList<TerminalManagementActionResult1Code> ActionResult { get; init; } = new SimpleValueList<TerminalManagementActionResult1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _FqWngR3ZEeKKrOIoqWglDw
    
    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    [IsoId("_FqWnhR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action To Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnToPrc")]
    #endif
    [IsoXmlTag("ActnToPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementErrorAction2Code ActionToProcess { get; init; } 
    #else
    public TerminalManagementErrorAction2Code ActionToProcess { get; set; } 
    #endif
    
    
    #nullable disable
    
}
