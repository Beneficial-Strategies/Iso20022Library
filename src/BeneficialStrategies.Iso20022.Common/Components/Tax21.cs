// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_agWyYRuHEeOqSdXzJ0oydA")]
[DisplayName("Tax")]
public record Tax21
{
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_kXU3gBuHEeOqSdXzJ0oydA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType1Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_a33TfRuHEeOqSdXzJ0oydA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Basis used to determine the capital gain or loss, for example, the purchase price.
    /// </summary>
    [IsoId("_QyTjQBuIEeOqSdXzJ0oydA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public required TaxBasis1Choice_ Basis { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_a33TgxuHEeOqSdXzJ0oydA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_a33ThRuHEeOqSdXzJ0oydA")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_L3s1ABuJEeOqSdXzJ0oydA")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_0wuTIBwcEeOIveEnnb_1-A")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation8? TaxCalculationDetails { get; init; }
}
