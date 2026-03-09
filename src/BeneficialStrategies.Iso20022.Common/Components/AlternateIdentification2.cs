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
/// Alternate identification of a security.
/// </summary>
[IsoId("_W9bqO9p-Ed-ak6NoX_4Aeg_419486529")]
[DisplayName("Alternate Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternateIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternateIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternateIdentification2( System.String reqIdentification,IdentificationSource2Choice_ reqIdentificationSource )
    {
        Identification = reqIdentification;
        IdentificationSource = reqIdentificationSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_W9bqPNp-Ed-ak6NoX_4Aeg_-1574658177")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax31Text)]
    [StringLength(maximumLength: 31 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax31Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    [IsoId("_W9k0INp-Ed-ak6NoX_4Aeg_-1624701768")]
    [DisplayName("Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdSrc")]
    #endif
    [IsoXmlTag("IdSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationSource2Choice_ IdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationSource2Choice_ IdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationSource2Choice_ IdentificationSource { get; init; } 
    #else
    public IdentificationSource2Choice_ IdentificationSource { get; set; } 
    #endif
    
    
    #nullable disable
    
}
