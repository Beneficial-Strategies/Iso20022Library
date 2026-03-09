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
/// Information to log.
/// </summary>
[IsoId("_TqzxMYO6EeSWSLYdc10LRg")]
[DisplayName("Action Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActionMessage3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionMessage3( UserInterface3Code reqDestination,System.String reqContent )
    {
        Destination = reqDestination;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the information.
    /// </summary>
    [IsoId("_T37AIYO6EeSWSLYdc10LRg")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface3Code Destination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface3Code Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface3Code Destination { get; init; } 
    #else
    public UserInterface3Code Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the content.
    /// </summary>
    [IsoId("_T37AI4O6EeSWSLYdc10LRg")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat1Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat1Code? Format { get; init; } 
    #else
    public OutputFormat1Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the information.
    /// </summary>
    [IsoId("_T37AJYO6EeSWSLYdc10LRg")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20000Text Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Content { get; init; } 
    #else
    public System.String Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
