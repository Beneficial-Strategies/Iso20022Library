// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecord3"/>
[IsoId("_n9ZPV94lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Record")]
public partial record TaxRecord3
{
    /// <inheritdoc cref="ITaxRecord3.Type"/>
    [IsoId("_n-65Qd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <inheritdoc cref="ITaxRecord3.Category"/>
    [IsoId("_n-65Q94lEeqt1ZcLzWyWFw")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Category { get; init; }

    /// <inheritdoc cref="ITaxRecord3.CategoryDetails"/>
    [IsoId("_n-65Rd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDetails { get; init; }

    /// <inheritdoc cref="ITaxRecord3.DebtorStatus"/>
    [IsoId("_n-65R94lEeqt1ZcLzWyWFw")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorStatus { get; init; }

    /// <inheritdoc cref="ITaxRecord3.CertificateIdentification"/>
    [IsoId("_n-65Sd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; }

    /// <inheritdoc cref="ITaxRecord3.FormsCode"/>
    [IsoId("_n-65S94lEeqt1ZcLzWyWFw")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ITaxRecord3.Period"/>
    [IsoId("_n-65Td4lEeqt1ZcLzWyWFw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod3? Period { get; init; }

    /// <inheritdoc cref="ITaxRecord3.TaxAmount"/>
    [IsoId("_n-65T94lEeqt1ZcLzWyWFw")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmount3? TaxAmount { get; init; }

    /// <inheritdoc cref="ITaxRecord3.AdditionalInformation"/>
    [IsoId("_n-65Ud4lEeqt1ZcLzWyWFw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
