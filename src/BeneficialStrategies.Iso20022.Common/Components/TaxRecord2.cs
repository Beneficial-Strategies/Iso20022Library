// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the tax record.
/// </summary>
[IsoId("_yKFWd69fEeen6L7OP7lnvg")]
[DisplayName("Tax Record")]
public partial record TaxRecord2
{
    #nullable enable
    
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    [IsoId("_yeA_A69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    [IsoId("_yeA_Ba9fEeen6L7OP7lnvg")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Category { get; init; } 
    
    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    [IsoId("_yeA_B69fEeen6L7OP7lnvg")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CategoryDetails { get; init; } 
    
    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    [IsoId("_yeA_Ca9fEeen6L7OP7lnvg")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DebtorStatus { get; init; } 
    
    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    [IsoId("_yeA_C69fEeen6L7OP7lnvg")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; } 
    
    /// <summary>
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    [IsoId("_yeA_Da9fEeen6L7OP7lnvg")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_yeA_D69fEeen6L7OP7lnvg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod2? Period { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    [IsoId("_yeA_Ea9fEeen6L7OP7lnvg")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmount2? TaxAmount { get; init; } 
    
    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    [IsoId("_yeA_E69fEeen6L7OP7lnvg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
