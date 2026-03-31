// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pricing component, such as a service, promotion, allowance or charge, for this line item.
/// </summary>
[IsoId("_S0Q8TgEcEeCQm6a_G2yO_w_145447968")]
[DisplayName("Line Item Allowance Charge")]
public record LineItemAllowanceCharge1
{
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    [IsoId("_S0Q8TwEcEeCQm6a_G2yO_w_2144378337")]
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargeIndicator { get; init; }

    /// <summary>
    /// Actual monetary value of this allowance charge.
    /// </summary>
    [IsoId("_S0Q8UAEcEeCQm6a_G2yO_w_1865072585")]
    [DisplayName("Actual Amount")]
    [IsoXmlTag("ActlAmt")]
    public ValueList<CurrencyAndAmount> ActualAmount { get; init; } = [];

    /// <summary>
    /// Quantity on which this allowance charge is based.
    /// </summary>
    [IsoId("_S0aGIAEcEeCQm6a_G2yO_w_700685910")]
    [DisplayName("Basis Quantity")]
    [IsoXmlTag("BsisQty")]
    public Quantity3? BasisQuantity { get; init; }

    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    [IsoId("_S0aGIQEcEeCQm6a_G2yO_w_-642810795")]
    [DisplayName("Calculation Percent")]
    [IsoXmlTag("ClctnPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculationPercent { get; init; }

    /// <summary>
    /// Specifies the order in which the allowance or charge is applied.
    /// </summary>
    [IsoId("_S0aGIgEcEeCQm6a_G2yO_w_-1141593647")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Reason, expressed as text, for this allowance charge.
    /// </summary>
    [IsoId("_S0aGIwEcEeCQm6a_G2yO_w_-1352166303")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public DiscountOrChargeType1Choice_? Reason { get; init; }
}
