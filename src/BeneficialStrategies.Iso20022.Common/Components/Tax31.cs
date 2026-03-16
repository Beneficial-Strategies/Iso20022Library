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
[IsoId("__6VlRzbsEead9bDRE_1DAQ")]
[DisplayName("Tax")]
public record Tax31
{
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_ASu3FzbtEead9bDRE_1DAQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_ASu3GzbtEead9bDRE_1DAQ")]
    [DisplayName("Applied Amount")]
    [IsoXmlTag("ApldAmt")]
    public required ActiveCurrencyAndAmount AppliedAmount { get; init; }

    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_ASu3HTbtEead9bDRE_1DAQ")]
    [DisplayName("Applied Rate")]
    [IsoXmlTag("ApldRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AppliedRate { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_ASu3HzbtEead9bDRE_1DAQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_ASu3ITbtEead9bDRE_1DAQ")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_ASu3KTbtEead9bDRE_1DAQ")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; }
}
