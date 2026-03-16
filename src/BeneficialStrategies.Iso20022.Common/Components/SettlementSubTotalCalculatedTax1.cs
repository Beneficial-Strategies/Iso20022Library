// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the subtotal calculated tax applicable for this settlement.
/// </summary>
[IsoId("_S0j3JQEcEeCQm6a_G2yO_w_-1391363136")]
[DisplayName("Settlement Sub Total Calculated Tax")]
public record SettlementSubTotalCalculatedTax1
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_S0j3JgEcEeCQm6a_G2yO_w_894669063")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? TypeCode { get; init; }

    /// <summary>
    /// Reference used to identify the nature of tax levied, such as Value Added Tax (VAT).
    /// </summary>
    [IsoId("_S0j3JwEcEeCQm6a_G2yO_w_-604171621")]
    [DisplayName("Category Code")]
    [IsoXmlTag("CtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? CategoryCode { get; init; }

    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3KAEcEeCQm6a_G2yO_w_1356444979")]
    [DisplayName("Calculated Amount")]
    [IsoXmlTag("ClctdAmt")]
    public CurrencyAndAmount? CalculatedAmount { get; init; }

    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_S0j3KQEcEeCQm6a_G2yO_w_-878123317")]
    [DisplayName("Basis Amount")]
    [IsoXmlTag("BsisAmt")]
    public CurrencyAndAmount? BasisAmount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3KgEcEeCQm6a_G2yO_w_-1188081468")]
    [DisplayName("Calculated Rate")]
    [IsoXmlTag("ClctdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculatedRate { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_S0j3KwEcEeCQm6a_G2yO_w_-1889469346")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptionReason1? ExemptionReason { get; init; }
}
