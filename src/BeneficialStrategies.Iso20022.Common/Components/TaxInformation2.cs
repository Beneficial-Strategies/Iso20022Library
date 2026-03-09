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
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_RvflsNp-Ed-ak6NoX_4Aeg_-311641782")]
[DisplayName("Tax Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Tax Identification Number of the creditor.
    /// </summary>
    [IsoId("_Rvflsdp-Ed-ak6NoX_4Aeg_-297789542")]
    [DisplayName("Creditor Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrTaxId")]
    #endif
    [IsoXmlTag("CdtrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditorTaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorTaxIdentification { get; init; } 
    #else
    public System.String? CreditorTaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of tax payer (creditor).
    /// </summary>
    [IsoId("_Rvflstp-Ed-ak6NoX_4Aeg_-299636535")]
    [DisplayName("Creditor Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrTaxTp")]
    #endif
    [IsoXmlTag("CdtrTaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditorTaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorTaxType { get; init; } 
    #else
    public System.String? CreditorTaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax Identification Number of the debtor.
    /// </summary>
    [IsoId("_Rvfls9p-Ed-ak6NoX_4Aeg_-298710996")]
    [DisplayName("Debtor Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrTaxId")]
    #endif
    [IsoXmlTag("DbtrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DebtorTaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorTaxIdentification { get; init; } 
    #else
    public System.String? DebtorTaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_RvfltNp-Ed-ak6NoX_4Aeg_-299634098")]
    [DisplayName("Tax Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRefNb")]
    #endif
    [IsoXmlTag("TaxRefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TaxReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxReferenceNumber { get; init; } 
    #else
    public System.String? TaxReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_Rvfltdp-Ed-ak6NoX_4Aeg_-298713029")]
    [DisplayName("Total Taxable Base Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxblBaseAmt")]
    #endif
    [IsoXmlTag("TtlTaxblBaseAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    #else
    public CurrencyAndAmount? TotalTaxableBaseAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_Rvflttp-Ed-ak6NoX_4Aeg_-298712514")]
    [DisplayName("Total Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxAmt")]
    #endif
    [IsoXmlTag("TtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalTaxAmount { get; init; } 
    #else
    public CurrencyAndAmount? TotalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_Rvflt9p-Ed-ak6NoX_4Aeg_-1970878326")]
    [DisplayName("Tax Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDt")]
    #endif
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TaxDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TaxDate { get; init; } 
    #else
    public System.DateOnly? TaxDate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of characteristics defining the type of tax.
    /// </summary>
    [IsoId("_RvfluNp-Ed-ak6NoX_4Aeg_-296863056")]
    [DisplayName("Tax Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTpInf")]
    #endif
    [IsoXmlTag("TaxTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxDetails? TaxTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxDetails? TaxTypeInformation { get; init; } 
    #else
    public TaxDetails? TaxTypeInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
