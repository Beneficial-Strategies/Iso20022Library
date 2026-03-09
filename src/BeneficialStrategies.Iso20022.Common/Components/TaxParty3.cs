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
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_SknWoAEcEeCQm6a_G2yO_w_-837981111")]
[DisplayName("Tax Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxParty3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_SknWoQEcEeCQm6a_G2yO_w_1225150116")]
    [DisplayName("Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxId")]
    #endif
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxIdentification { get; init; } 
    #else
    public System.String? TaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_SknWogEcEeCQm6a_G2yO_w_1724761612")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxType { get; init; } 
    #else
    public System.String? TaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_SknWowEcEeCQm6a_G2yO_w_1665746426")]
    [DisplayName("Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnId")]
    #endif
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationIdentification { get; init; } 
    #else
    public System.String? RegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of the tax exemption reason.
    /// </summary>
    [IsoId("_SknWpAEcEeCQm6a_G2yO_w_377116311")]
    [DisplayName("Tax Exemption Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxXmptnRsn")]
    #endif
    [IsoXmlTag("TaxXmptnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptionReasonFormatChoice_? TaxExemptionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptionReasonFormatChoice_? TaxExemptionReason { get; init; } 
    #else
    public TaxExemptionReasonFormatChoice_? TaxExemptionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
