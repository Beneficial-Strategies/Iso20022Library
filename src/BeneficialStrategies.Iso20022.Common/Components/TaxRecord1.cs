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
/// Set of elements used to define the tax record.
/// </summary>
[IsoId("_UP-lfdp-Ed-ak6NoX_4Aeg_-1626596263")]
[DisplayName("Tax Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    [IsoId("_UP-lftp-Ed-ak6NoX_4Aeg_-1148727004")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    [IsoId("_UQIWcNp-Ed-ak6NoX_4Aeg_1498485302")]
    [DisplayName("Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctgy")]
    #endif
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Category { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Category { get; init; } 
    #else
    public System.String? Category { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    [IsoId("_UQIWcdp-Ed-ak6NoX_4Aeg_1500331706")]
    [DisplayName("Category Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyDtls")]
    #endif
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CategoryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CategoryDetails { get; init; } 
    #else
    public System.String? CategoryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    [IsoId("_UQIWctp-Ed-ak6NoX_4Aeg_-1691952532")]
    [DisplayName("Debtor Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrSts")]
    #endif
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DebtorStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorStatus { get; init; } 
    #else
    public System.String? DebtorStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    [IsoId("_UQIWc9p-Ed-ak6NoX_4Aeg_-1626596261")]
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
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    [IsoId("_UQIWdNp-Ed-ak6NoX_4Aeg_-1462919201")]
    [DisplayName("Forms Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmsCd")]
    #endif
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FormsCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FormsCode { get; init; } 
    #else
    public System.String? FormsCode { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_UQIWddp-Ed-ak6NoX_4Aeg_-1864651230")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxPeriod1? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxPeriod1? Period { get; init; } 
    #else
    public TaxPeriod1? Period { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    [IsoId("_UQIWdtp-Ed-ak6NoX_4Aeg_-1626595952")]
    [DisplayName("Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAmt")]
    #endif
    [IsoXmlTag("TaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxAmount1? TaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxAmount1? TaxAmount { get; init; } 
    #else
    public TaxAmount1? TaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    [IsoId("_UQIWd9p-Ed-ak6NoX_4Aeg_-576338980")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
