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
/// Restriction information details.
/// </summary>
[IsoId("_c1-rgMnIEeWGzao7PBKDrg")]
[DisplayName("Restriction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RestrictionDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RestrictionDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RestrictionDetailsSD1( GenericIdentification36 reqRestrictionType,string reqFiscalDomicile,System.String reqIdentification )
    {
        RestrictionType = reqRestrictionType;
        FiscalDomicile = reqFiscalDomicile;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of restriction.
    /// </summary>
    [IsoId("_iS3K8MnIEeWGzao7PBKDrg")]
    [DisplayName("Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnTp")]
    #endif
    [IsoXmlTag("RstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification36 RestrictionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification36 RestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36 RestrictionType { get; init; } 
    #else
    public GenericIdentification36 RestrictionType { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_n7yiUMnIEeWGzao7PBKDrg")]
    [DisplayName("Fiscal Domicile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclDmcl")]
    #endif
    [IsoXmlTag("FsclDmcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode FiscalDomicile { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string FiscalDomicile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string FiscalDomicile { get; init; } 
    #else
    public string FiscalDomicile { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the applicable restriction.
    /// </summary>
    [IsoId("_3RQ3gMnIEeWGzao7PBKDrg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
