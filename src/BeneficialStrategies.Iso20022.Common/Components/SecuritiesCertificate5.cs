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
/// Physical representation of a security.
/// </summary>
[IsoId("_5TJXe5NLEeWGlc8L7oPDIg")]
[DisplayName("Securities Certificate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesCertificate5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesCertificate5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesCertificate5( System.String reqNumber )
    {
        Number = reqNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_5TJXf5NLEeWGlc8L7oPDIg")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
    [StringLength(maximumLength: 30 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax30Text Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Number { get; init; } 
    #else
    public System.String Number { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5TJXh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_5TJXj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Scheme Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchmeNm")]
    #endif
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SchemeName { get; init; } 
    #else
    public System.String? SchemeName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
