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
[IsoId("_Vu_qkTh9EeaH-93K5JKmzw")]
[DisplayName("Tax")]
public record Tax32
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_WHZjhzh9EeaH-93K5JKmzw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax. This amount is provided for information only.
    /// </summary>
    [IsoId("_WHZjiTh9EeaH-93K5JKmzw")]
    [DisplayName("Informative Amount")]
    [IsoXmlTag("InftvAmt")]
    public ActiveCurrencyAndAmount? InformativeAmount { get; init; }

    /// <summary>
    /// Rate used to calculate the tax. This rate is provided for information only.
    /// </summary>
    [IsoId("_WHZjizh9EeaH-93K5JKmzw")]
    [DisplayName("Informative Rate")]
    [IsoXmlTag("InftvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InformativeRate { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_WHZjjTh9EeaH-93K5JKmzw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_WHZjkTh9EeaH-93K5JKmzw")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("_WHZjkzh9EeaH-93K5JKmzw")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_sK5AMXTTEea79aegl3yVYg")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_Gp-WwTh-EeaH-93K5JKmzw")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; }
}
