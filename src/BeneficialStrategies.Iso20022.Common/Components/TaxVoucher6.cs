// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax voucher details.
/// </summary>
[IsoId("_VWACAajzEfCG_LQaXOxwew")]
[DisplayName("Tax Voucher6")]
public record TaxVoucher6
{
    [IsoId("_VWACAajzEfCG_LQaXOxwew-tvrf")]
    [DisplayName("Tax Voucher Reference")]
    [IsoXmlTag("TaxVchrRef")]
    public IsoMax35Text? TaxVoucherReference { get; init; }

    [IsoId("_VWACAajzEfCG_LQaXOxwew-trdr")]
    [DisplayName("Tax Reclaim Documentation Reference")]
    [IsoXmlTag("TaxRclmDocRef")]
    public IsoMax35Text? TaxReclaimDocumentationReference { get; init; }

    [IsoId("_VWACAajzEfCG_LQaXOxwew-borf")]
    [DisplayName("Beneficial Owner Reference")]
    [IsoXmlTag("BnfclOwnrRef")]
    public IsoMax35Text? BeneficialOwnerReference { get; init; }
}
