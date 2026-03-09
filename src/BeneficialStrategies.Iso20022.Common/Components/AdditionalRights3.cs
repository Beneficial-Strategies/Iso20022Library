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
/// Information about additional rights that can be granted for a meeting.
/// </summary>
[IsoId("_k8fcwa09EemDtrWpq90Ckg")]
[DisplayName("Additional Rights")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalRights3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalRights3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalRights3( AdditionalRightCode1Choice_ reqAdditionalRight )
    {
        AdditionalRight = reqAdditionalRight;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific rights granted to the shareholders that can be exercised at shareholders meetings, for example, the right to ask questions, the right to add items to the agenda or table draft resolutions.
    /// </summary>
    [IsoId("_lReOMa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRght")]
    #endif
    [IsoXmlTag("AddtlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalRightCode1Choice_ AdditionalRight { get; init; } 
    #else
    public AdditionalRightCode1Choice_ AdditionalRight { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on specific rights granted to the shareholders can be found.
    /// </summary>
    [IsoId("_lReOM609EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Information URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtInfURLAdr")]
    #endif
    [IsoXmlTag("AddtlRghtInfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? AdditionalRightInformationURLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalRightInformationURLAddress { get; init; } 
    #else
    public System.String? AdditionalRightInformationURLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_lReONa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtDdln")]
    #endif
    [IsoXmlTag("AddtlRghtDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? AdditionalRightDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? AdditionalRightDeadline { get; init; } 
    #else
    public DateFormat58Choice_? AdditionalRightDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to determine the date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_lReON609EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtMktDdln")]
    #endif
    [IsoXmlTag("AddtlRghtMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? AdditionalRightMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? AdditionalRightMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? AdditionalRightMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_lReOOa09EemDtrWpq90Ckg")]
    [DisplayName("Additional Right Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRghtThrshld")]
    #endif
    [IsoXmlTag("AddtlRghtThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; init; } 
    #else
    public AdditionalRightThreshold1Choice_? AdditionalRightThreshold { get; set; } 
    #endif
    
    
    #nullable disable
    
}
