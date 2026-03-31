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
[IsoId("_p37YMZ9BEeqxTNfi5y7ywQ")]
[DisplayName("Individual Cost Or Charge")]
public record IndividualCostOrCharge2
{
    /// <summary>
    /// Type of cost or charge.
    /// </summary>
    [IsoId("_qPIXNZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Cost Type")]
    [IsoXmlTag("CostTp")]
    public required ChargeType8Choice_ CostType { get; init; }

    /// <summary>
    /// Specifies if the cost or charge is ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_qPIXN59BEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Ante Or Ex Post")]
    [IsoXmlTag("ExAnteOrExPst")]
    public required IntendedOrActual2Code ExAnteOrExPost { get; init; }

    /// <summary>
    /// Amount of the cost or charge.
    /// </summary>
    [IsoId("_qPIXOZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Indicates a negative amount.
    /// </summary>
    [IsoId("_-0re4Z9BEeqxTNfi5y7ywQ")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }

    /// <summary>
    /// Rate of the cost or charge.
    /// </summary>
    [IsoId("_qPIXO59BEeqxTNfi5y7ywQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Start date and end date of the reference period for the ex post cost or charge. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08090 and 08100.
    /// </summary>
    [IsoId("_qPIXPZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Reference Period")]
    [IsoXmlTag("RefPrd")]
    public Period15? ReferencePeriod { get; init; }

    /// <summary>
    /// Additional information about the individual cost or charge.
    /// </summary>
    [IsoId("_qPIXP59BEeqxTNfi5y7ywQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
