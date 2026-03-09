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
/// Restrictions applicable to the security.
/// </summary>
[IsoId("_cW1DkeLxEeWOD7aAy2fAcA")]
[DisplayName("Security Restriction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityRestriction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the restriction applies.
    /// </summary>
    [IsoId("_cg8o4eLxEeWOD7aAy2fAcA")]
    [DisplayName("Effective Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvPrd")]
    #endif
    [IsoXmlTag("FctvPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriodDetails1? EffectivePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodDetails1? EffectivePeriod { get; init; } 
    #else
    public DateTimePeriodDetails1? EffectivePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_cg8o4-LxEeWOD7aAy2fAcA")]
    [DisplayName("Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnTp")]
    #endif
    [IsoXmlTag("RstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; } 
    #else
    public SecurityRestrictionType2Choice_? RestrictionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_cg8o5eLxEeWOD7aAy2fAcA")]
    [DisplayName("Legal Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctnTp")]
    #endif
    [IsoXmlTag("LglRstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; } 
    #else
    public LegalRestrictions5Choice_? LegalRestrictionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the restriction to be applied is relevant for citizen, resident, country.
    /// </summary>
    [IsoId("_cg8o5-LxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrRstrctnTp")]
    #endif
    [IsoXmlTag("InvstrRstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; init; } 
    #else
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of investor that is allowed to hold the security.
    /// </summary>
    [IsoId("_cg8o6eLxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTp")]
    #endif
    [IsoXmlTag("InvstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType3Choice_? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType3Choice_? InvestorType { get; init; } 
    #else
    public InvestorType3Choice_? InvestorType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
