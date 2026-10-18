// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxDetails"/>
[IsoId("_RvWbwNp-Ed-ak6NoX_4Aeg_-1792079217")]
[DisplayName("Tax Details")]
public partial record TaxDetails
{
    /// <inheritdoc cref="ITaxDetails.CertificateIdentification"/>
    [IsoId("_RvWbwdp-Ed-ak6NoX_4Aeg_-1514098436")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; }

    /// <inheritdoc cref="ITaxDetails.TaxType"/>
    [IsoId("_RvWbwtp-Ed-ak6NoX_4Aeg_1885832221")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    public TaxType? TaxType { get; init; }
}
