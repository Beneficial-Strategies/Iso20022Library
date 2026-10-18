// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecord2"/>
[IsoId("_yKFWd69fEeen6L7OP7lnvg")]
[DisplayName("Tax Record")]
public partial record TaxRecord2
{
    /// <inheritdoc cref="ITaxRecord2.Type"/>
    [IsoId("_yeA_A69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <inheritdoc cref="ITaxRecord2.Category"/>
    [IsoId("_yeA_Ba9fEeen6L7OP7lnvg")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Category { get; init; }

    /// <inheritdoc cref="ITaxRecord2.CategoryDetails"/>
    [IsoId("_yeA_B69fEeen6L7OP7lnvg")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDetails { get; init; }

    /// <inheritdoc cref="ITaxRecord2.DebtorStatus"/>
    [IsoId("_yeA_Ca9fEeen6L7OP7lnvg")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorStatus { get; init; }

    /// <inheritdoc cref="ITaxRecord2.CertificateIdentification"/>
    [IsoId("_yeA_C69fEeen6L7OP7lnvg")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; }

    /// <inheritdoc cref="ITaxRecord2.FormsCode"/>
    [IsoId("_yeA_Da9fEeen6L7OP7lnvg")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ITaxRecord2.Period"/>
    [IsoId("_yeA_D69fEeen6L7OP7lnvg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod2? Period { get; init; }

    /// <inheritdoc cref="ITaxRecord2.TaxAmount"/>
    [IsoId("_yeA_Ea9fEeen6L7OP7lnvg")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmount2? TaxAmount { get; init; }

    /// <inheritdoc cref="ITaxRecord2.AdditionalInformation"/>
    [IsoId("_yeA_E69fEeen6L7OP7lnvg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
