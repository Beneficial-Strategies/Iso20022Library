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
    /// <summary>
    /// Unique reference for the tax voucher required by the relevant tax authorities to ensure that any claim relating to this particular tax voucher cannot be duplicated.
    /// </summary>
    [IsoId("_VWACAajzEfCG_LQaXOxwew-tvrf")]
    [DisplayName("Tax Voucher Reference")]
    [IsoXmlTag("TaxVchrRef")]
    public IsoMax35Text? TaxVoucherReference { get; init; }

    /// <summary>
    /// Unique reference assigned by the account owner to the tax documentation sent to the account servicer for processing.
    /// </summary>
    [IsoId("_VWACAajzEfCG_LQaXOxwew-trdr")]
    [DisplayName("Tax Reclaim Documentation Reference")]
    [IsoXmlTag("TaxRclmDocRef")]
    public IsoMax35Text? TaxReclaimDocumentationReference { get; init; }

    /// <summary>
    /// Unique reference identifying the beneficial owner the refund applies to, as assigned by the account owner to the tax documentation sent to the account servicer for processing.
    /// </summary>
    [IsoId("_VWACAajzEfCG_LQaXOxwew-borf")]
    [DisplayName("Beneficial Owner Reference")]
    [IsoXmlTag("BnfclOwnrRef")]
    public IsoMax35Text? BeneficialOwnerReference { get; init; }
}
