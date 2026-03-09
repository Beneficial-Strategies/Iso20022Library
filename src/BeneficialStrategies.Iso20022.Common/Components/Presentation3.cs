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
/// Electronic presentation information.
/// </summary>
[IsoId("_97IpNHltEeG7BsjMvd1mEw_776064240")]
[DisplayName("Presentation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Presentation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Format for presentation documents that are submitted electronically.
    /// </summary>
    [IsoId("_97RzIHltEeG7BsjMvd1mEw_1774083101")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentFormat1Choice_? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentFormat1Choice_? Format { get; init; } 
    #else
    public DocumentFormat1Choice_? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Channel through which presentation documents are submitted electronically, such as SWIFT, Web upload, or secure email.
    /// </summary>
    [IsoId("_97RzIXltEeG7BsjMvd1mEw_-403292535")]
    [DisplayName("Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chanl")]
    #endif
    [IsoXmlTag("Chanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Channel1Choice_? Channel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Channel1Choice_? Channel { get; init; } 
    #else
    public Channel1Choice_? Channel { get; set; } 
    #endif
    
    /// <summary>
    /// Uniform Resource Identifier (URI), such as a web or an email address, specifying where the presentation can be addressed.
    /// </summary>
    [IsoId("_97RzInltEeG7BsjMvd1mEw_837339061")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Address { get; init; } 
    #else
    public System.String? Address { get; set; } 
    #endif
    
    
    #nullable disable
    
}
