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
/// Specifies the owner type and mandate type.
/// </summary>
[IsoId("_rv8cQC_-EeOKib24wnHaFg")]
[DisplayName("Owner Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OwnerType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OwnerType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OwnerType1( AccountOwnerType1Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of ownership.
    /// </summary>
    [IsoId("_xXmBQC_-EeOKib24wnHaFg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountOwnerType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountOwnerType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountOwnerType1Code Type { get; init; } 
    #else
    public AccountOwnerType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of mandate.
    /// </summary>
    [IsoId("_Fkj7YJiuEeO4o528ngEXuw")]
    [DisplayName("Mandate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtTp")]
    #endif
    [IsoXmlTag("MndtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountPermissionType1Code? MandateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountPermissionType1Code? MandateType { get; init; } 
    #else
    public AccountPermissionType1Code? MandateType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about owner type or mandate type in proprietary format.
    /// </summary>
    [IsoId("_1p5j8C_-EeOKib24wnHaFg")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? Proprietary { get; init; } 
    #else
    public GenericIdentification1? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
