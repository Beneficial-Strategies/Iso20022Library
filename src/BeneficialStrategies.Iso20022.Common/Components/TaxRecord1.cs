// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxRecord1"/>
[IsoId("_UP-lfdp-Ed-ak6NoX_4Aeg_-1626596263")]
[DisplayName("Tax Record")]
public partial record TaxRecord1
{
    /// <inheritdoc cref="ITaxRecord1.Type"/>
    [IsoId("_UP-lftp-Ed-ak6NoX_4Aeg_-1148727004")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <inheritdoc cref="ITaxRecord1.Category"/>
    [IsoId("_UQIWcNp-Ed-ak6NoX_4Aeg_1498485302")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Category { get; init; }

    /// <inheritdoc cref="ITaxRecord1.CategoryDetails"/>
    [IsoId("_UQIWcdp-Ed-ak6NoX_4Aeg_1500331706")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDetails { get; init; }

    /// <inheritdoc cref="ITaxRecord1.DebtorStatus"/>
    [IsoId("_UQIWctp-Ed-ak6NoX_4Aeg_-1691952532")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorStatus { get; init; }

    /// <inheritdoc cref="ITaxRecord1.CertificateIdentification"/>
    [IsoId("_UQIWc9p-Ed-ak6NoX_4Aeg_-1626596261")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; }

    /// <inheritdoc cref="ITaxRecord1.FormsCode"/>
    [IsoId("_UQIWdNp-Ed-ak6NoX_4Aeg_-1462919201")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ITaxRecord1.Period"/>
    [IsoId("_UQIWddp-Ed-ak6NoX_4Aeg_-1864651230")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod1? Period { get; init; }

    /// <inheritdoc cref="ITaxRecord1.TaxAmount"/>
    [IsoId("_UQIWdtp-Ed-ak6NoX_4Aeg_-1626595952")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmount1? TaxAmount { get; init; }

    /// <inheritdoc cref="ITaxRecord1.AdditionalInformation"/>
    [IsoId("_UQIWd9p-Ed-ak6NoX_4Aeg_-576338980")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
