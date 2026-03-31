// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Individual cost or charge associated with the distribution or selling of a financial instrument. It may be one-off or recurring charge. It may be intended (ex ante) or actual (ex post).
/// </summary>
[IsoId("_Botp4IwSEeicrr-UkGlMQA")]
[DisplayName("Individual Cost Or Charge")]
public record IndividualCostOrCharge1
{
    /// <summary>
    /// Type of cost or charge.
    /// </summary>
    [IsoId("_Xr07x4wSEeicrr-UkGlMQA")]
    [DisplayName("Cost Type")]
    [IsoXmlTag("CostTp")]
    public required ChargeType7Choice_ CostType { get; init; }

    /// <summary>
    /// Specifies if the cost or charge is ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_Xr07yIwSEeicrr-UkGlMQA")]
    [DisplayName("Ex Ante Or Ex Post")]
    [IsoXmlTag("ExAnteOrExPst")]
    public required IntendedOrActual2Code ExAnteOrExPost { get; init; }

    /// <summary>
    /// Amount of the cost or charge.
    /// </summary>
    [IsoId("_Xr07yYwSEeicrr-UkGlMQA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Rate of the cost or charge.
    /// </summary>
    [IsoId("_Xr07yowSEeicrr-UkGlMQA")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Start date and end date of the calculation period for the ex post cost or charge. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08090 and 08100.
    /// </summary>
    [IsoId("_Xr07y4wSEeicrr-UkGlMQA")]
    [DisplayName("Calculation Period")]
    [IsoXmlTag("ClctnPrd")]
    public Period15? CalculationPeriod { get; init; }

    /// <summary>
    /// Additional information about the individual cost or charge.
    /// </summary>
    [IsoId("_Xr07zYwSEeicrr-UkGlMQA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
