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
/// Restriction on capability or operations allowed.
/// </summary>
[IsoId("_PUhYHtp-Ed-ak6NoX_4Aeg_-335182924")]
[DisplayName("Restriction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Restriction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Restriction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Restriction1( CodeOrProprietary1Choice_ reqRestrictionType,System.DateTime reqValidFrom )
    {
        RestrictionType = reqRestrictionType;
        ValidFrom = reqValidFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the restriction.
    /// </summary>
    [IsoId("_PUhYH9p-Ed-ak6NoX_4Aeg_1543244557")]
    [DisplayName("Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnTp")]
    #endif
    [IsoXmlTag("RstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CodeOrProprietary1Choice_ RestrictionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CodeOrProprietary1Choice_ RestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CodeOrProprietary1Choice_ RestrictionType { get; init; } 
    #else
    public CodeOrProprietary1Choice_ RestrictionType { get; set; } 
    #endif
    
    /// <summary>
    /// Date from when the restriction is valid.
    /// </summary>
    [IsoId("_PUhYINp-Ed-ak6NoX_4Aeg_736440027")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ValidFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ValidFrom { get; init; } 
    #else
    public System.DateTime ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Date until when the restriction is valid.
    /// </summary>
    [IsoId("_PUrJENp-Ed-ak6NoX_4Aeg_1733310129")]
    [DisplayName("Valid Until")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldUntil")]
    #endif
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ValidUntil { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ValidUntil { get; init; } 
    #else
    public System.DateTime? ValidUntil { get; set; } 
    #endif
    
    
    #nullable disable
    
}
