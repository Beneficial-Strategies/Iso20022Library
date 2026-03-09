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
/// Type providing further information on balance restrictions.
/// </summary>
[IsoId("_8H0BRqMgEeCJ6YNENx4h-w_-1462773614")]
[DisplayName("Balance Restriction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceRestrictionType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceRestrictionType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceRestrictionType1( GenericIdentification1 reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_8H0BR6MgEeCJ6YNENx4h-w_-1080256634")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification1 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification1 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1 Type { get; init; } 
    #else
    public GenericIdentification1 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the restriction.
    /// </summary>
    [IsoId("_8H0BSKMgEeCJ6YNENx4h-w_1112293165")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the type of processing restriction that the system should apply for the restriction.
    /// </summary>
    [IsoId("_8H0BSaMgEeCJ6YNENx4h-w_-1123411091")]
    [DisplayName("Processing Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgTp")]
    #endif
    [IsoXmlTag("PrcgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingType1Choice_? ProcessingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingType1Choice_? ProcessingType { get; init; } 
    #else
    public ProcessingType1Choice_? ProcessingType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
