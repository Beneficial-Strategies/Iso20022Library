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
/// Set of characteristics defining the type of tax.
/// </summary>
[IsoId("_RvWbwNp-Ed-ak6NoX_4Aeg_-1792079217")]
[DisplayName("Tax Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxDetails
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Document issued by first agent on behalf of debtor to report withholding tax to taxing authority.
    /// </summary>
    [IsoId("_RvWbwdp-Ed-ak6NoX_4Aeg_-1514098436")]
    [DisplayName("Certificate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertId")]
    #endif
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateIdentification { get; init; } 
    #else
    public System.String? CertificateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the type of tax.
    /// </summary>
    [IsoId("_RvWbwtp-Ed-ak6NoX_4Aeg_1885832221")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxType? TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType? TaxType { get; init; } 
    #else
    public TaxType? TaxType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
