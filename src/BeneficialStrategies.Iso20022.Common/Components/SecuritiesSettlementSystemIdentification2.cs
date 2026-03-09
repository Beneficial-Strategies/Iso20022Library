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
/// Specifies the securities settlement system used in a settlement process.
/// </summary>
[IsoId("_h-yqwR2yEeqF2P5v-Rtejg")]
[DisplayName("Securities Settlement System Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementSystemIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementSystemIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementSystemIdentification2( System.String reqSystemIdentification )
    {
        SystemIdentification = reqSystemIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the securities settlement system.
    /// </summary>
    [IsoId("_iAmBkR2yEeqF2P5v-Rtejg")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SystemIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SystemIdentification { get; init; } 
    #else
    public System.String SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the securities settlement system.
    /// </summary>
    [IsoId("_iAmBkx2yEeqF2P5v-Rtejg")]
    [DisplayName("System Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysNm")]
    #endif
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SystemName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemName { get; init; } 
    #else
    public System.String? SystemName { get; set; } 
    #endif
    
    /// <summary>
    /// Country code for the jurisdiction in which the CSD is established.
    /// </summary>
    [IsoId("_iAmBlR2yEeqF2P5v-Rtejg")]
    [DisplayName("Country Of Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfJursdctn")]
    #endif
    [IsoXmlTag("CtryOfJursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfJurisdiction { get; init; } 
    #else
    public string? CountryOfJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Corporate name of the CSD.
    /// </summary>
    [IsoId("_iAmBlx2yEeqF2P5v-Rtejg")]
    [DisplayName("CSD Legal Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDLglNm")]
    #endif
    [IsoXmlTag("CSDLglNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CSDLegalName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CSDLegalName { get; init; } 
    #else
    public System.String? CSDLegalName { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification of the CSD operating the securities settlement system.
    /// </summary>
    [IsoId("_iAmBmR2yEeqF2P5v-Rtejg")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Party (such as a person or a team) responsible for the report sent by the CSD.
    /// </summary>
    [IsoId("_iAmBmx2yEeqF2P5v-Rtejg")]
    [DisplayName("Responsible Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPty")]
    #endif
    [IsoXmlTag("RspnsblPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact9? ResponsibleParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact9? ResponsibleParty { get; init; } 
    #else
    public Contact9? ResponsibleParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
