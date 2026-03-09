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
/// Identification information expressed as a country of fiscal domicile and a reference.
/// </summary>
[IsoId("_rQA50MqREeWyL6686qMenw")]
[DisplayName("Generic Identification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentificationSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentificationSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentificationSD1( string reqFiscalDomicile )
    {
        FiscalDomicile = reqFiscalDomicile;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_znnd8MqREeWyL6686qMenw")]
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
    /// Identification of the document assigned by the account servicer.
    /// </summary>
    [IsoId("_ozw2CO0QEeWLj6RCdgRMog")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerIdentification { get; init; } 
    #else
    public System.String? AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document assigned by the account owner.
    /// </summary>
    [IsoId("_ozw2DO0QEeWLj6RCdgRMog")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerIdentification { get; init; } 
    #else
    public System.String? AccountOwnerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
