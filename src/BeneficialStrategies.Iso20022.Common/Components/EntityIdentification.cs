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
/// Identification of a business entity, eg, corporate or financial institution.
/// </summary>
[IsoId("_WHybpNp-Ed-ak6NoX_4Aeg_1831804214")]
[DisplayName("Entity Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntityIdentification
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EntityIdentification instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EntityIdentification( System.String reqType,System.String reqEntityIdentifier )
    {
        Type = reqType;
        EntityIdentifier = reqEntityIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of identification, eg, BIC or URI.
    /// </summary>
    [IsoId("_WHybpdp-Ed-ak6NoX_4Aeg_285566508")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Type")]
    #endif
    [IsoXmlTag("Type")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Actual identification of the entity.
    /// </summary>
    [IsoId("_WHybptp-Ed-ak6NoX_4Aeg_388076065")]
    [DisplayName("Entity Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax30Text EntityIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EntityIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EntityIdentifier { get; init; } 
    #else
    public System.String EntityIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
