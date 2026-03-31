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
[IsoId("_VR_cHNp-Ed-ak6NoX_4Aeg_-1881206398")]
[DisplayName("Tax")]
public record Tax7
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_VR_cHdp-Ed-ak6NoX_4Aeg_-1881206038")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType2 Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_VR_cHtp-Ed-ak6NoX_4Aeg_-1880285359")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_VR_cH9p-Ed-ak6NoX_4Aeg_-1880285229")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_VSJNENp-Ed-ak6NoX_4Aeg_-1880285187")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_VSJNEdp-Ed-ak6NoX_4Aeg_-1880284796")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_VSJNEtp-Ed-ak6NoX_4Aeg_-1880284488")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptionReason1? ExemptionReason { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_VSJNE9p-Ed-ak6NoX_4Aeg_220128827")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation3? TaxCalculationDetails { get; init; }
}
