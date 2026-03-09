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
/// Specifies the tax identification related to a service to be billed.
/// </summary>
[IsoId("_6TYLLJqlEeGSON8vddiWzQ_-2138086814")]
[DisplayName("Billing Tax Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingTaxIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value added tax (VAT) registration number as provided by the region’s local taxing authority.
    /// </summary>
    [IsoId("_6TYLLZqlEeGSON8vddiWzQ_-845733598")]
    [DisplayName("VAT Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VATRegnNb")]
    #endif
    [IsoXmlTag("VATRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VATRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VATRegistrationNumber { get; init; } 
    #else
    public System.String? VATRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Tax registration number (TRN) as provided by the tax region’s local taxing authority.
    /// </summary>
    [IsoId("_6Th8IJqlEeGSON8vddiWzQ_-832304253")]
    [DisplayName("Tax Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRegnNb")]
    #endif
    [IsoXmlTag("TaxRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxRegistrationNumber { get; init; } 
    #else
    public System.String? TaxRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies financial institution&apos;s contact details for the tax region. This contact works for the financial institution, not the tax region.
    /// </summary>
    [IsoId("_6Th8IZqlEeGSON8vddiWzQ_-1556028091")]
    [DisplayName("Tax Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCtct")]
    #endif
    [IsoXmlTag("TaxCtct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactDetails3? TaxContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactDetails3? TaxContact { get; init; } 
    #else
    public ContactDetails3? TaxContact { get; set; } 
    #endif
    
    
    #nullable disable
    
}
