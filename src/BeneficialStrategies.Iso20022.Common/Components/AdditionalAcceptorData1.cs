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
/// Contains additional acceptor data
/// </summary>
[IsoId("_ZG0IJfJREeiJn9rM2Znz2w")]
[DisplayName("Additional Acceptor Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalAcceptorData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains a code that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [IsoId("_ZG0vMfJREeiJn9rM2Znz2w")]
    [DisplayName("Additional Transaction Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxRefNb")]
    #endif
    [IsoXmlTag("AddtlTxRefNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionReferenceNumber { get; init; } 
    #else
    public System.String? AdditionalTransactionReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the company recognized by the taxation authority.  Used for reporting transaction-related taxes.
    /// </summary>
    [IsoId("__OitIfJREeiJn9rM2Znz2w")]
    [DisplayName("Tax Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRegnId")]
    #endif
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TaxRegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxRegistrationIdentification { get; init; } 
    #else
    public System.String? TaxRegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the company recognized by the taxation authority.  Used for reporting corporate-related taxes.
    /// </summary>
    [IsoId("_ZG0vMvJREeiJn9rM2Znz2w")]
    [DisplayName("Corporate Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpTaxId")]
    #endif
    [IsoXmlTag("CorpTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CorporateTaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateTaxIdentification { get; init; } 
    #else
    public System.String? CorporateTaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the corporate tax identification type.
    /// </summary>
    [IsoId("_AFElwP41Eeix6ug6HlF6IQ")]
    [DisplayName("Corporate Tax Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpTaxIdTp")]
    #endif
    [IsoXmlTag("CorpTaxIdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; } 
    #else
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional identification information. 
    /// </summary>
    [IsoId("_ZG0vMPJREeiJn9rM2Znz2w")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalIdentification1? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalIdentification1? AdditionalIdentification { get; init; } 
    #else
    public AdditionalIdentification1? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains various classifications of business ownership characteristics.
    /// </summary>
    [IsoId("_0X-5oPJZEeiJn9rM2Znz2w")]
    [DisplayName("Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtcs")]
    #endif
    [IsoXmlTag("Chrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalCharacteristics1? Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalCharacteristics1? Characteristics { get; init; } 
    #else
    public AdditionalCharacteristics1? Characteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the card acceptor.
    /// </summary>
    [IsoId("_aVCxoPJYEeiJn9rM2Znz2w")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
