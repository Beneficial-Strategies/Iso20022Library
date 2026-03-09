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
/// Specifies the details to identify a financial institution.
/// </summary>
[IsoId("_8xXCNW49EeiU9cctagi5ow")]
[DisplayName("Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentification18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_87o_kW49EeiU9cctagi5ow")]
    [DisplayName("BICFI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BICFI")]
    #endif
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BICFI { get; init; } 
    #else
    public System.String? BICFI { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_87o_k249EeiU9cctagi5ow")]
    [DisplayName("Clearing System Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSysMmbId")]
    #endif
    [IsoXmlTag("ClrSysMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    #else
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identifier of the financial institution.
    /// </summary>
    [IsoId("_b1ZcUXRwEeiH1ZOt2UD8vQ")]
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
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    [IsoId("_87o_lW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_87o_l249EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? PostalAddress { get; init; } 
    #else
    public PostalAddress24? PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_87o_mW49EeiU9cctagi5ow")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericFinancialIdentification1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericFinancialIdentification1? Other { get; init; } 
    #else
    public GenericFinancialIdentification1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
