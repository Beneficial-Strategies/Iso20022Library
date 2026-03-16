// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a pricing component, such as a service, promotion, allowance or charge, for this trade settlement.
/// </summary>
[IsoId("_S0Q8SgEcEeCQm6a_G2yO_w_1558181804")]
[DisplayName("Settlement Allowance Charge")]
public record SettlementAllowanceCharge1
{
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    [IsoId("_S0Q8SwEcEeCQm6a_G2yO_w_23404513")]
    [DisplayName("Allowance Charge Indicator")]
    [IsoXmlTag("AllwncChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AllowanceChargeIndicator { get; init; }

    /// <summary>
    /// Actual monetary amount specified for the allowance or charge.
    /// </summary>
    [IsoId("_S0Q8TAEcEeCQm6a_G2yO_w_-2142675469")]
    [DisplayName("Actual Amount")]
    [IsoXmlTag("ActlAmt")]
    public ValueList<CurrencyAndAmount> ActualAmount { get; init; } = [];

    /// <summary>
    /// Reason, expressed as text, for this allowance or charge.
    /// </summary>
    [IsoId("_S0Q8TQEcEeCQm6a_G2yO_w_1081608763")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public DiscountOrChargeType1Choice_? Reason { get; init; }
}
