// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pricing component, such as a service, promotion, allowance or charge, for this line item.
/// </summary>
[IsoId("_b2YbYcNUEeWGDrnsYu2p6g")]
[DisplayName("Line Item Allowance Charge")]
public partial record LineItemAllowanceCharge2
{
    #nullable enable
    
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    [IsoId("_cCSJYcNUEeWGDrnsYu2p6g")]
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargeIndicator { get; init; } 
    
    /// <summary>
    /// Actual monetary value of this allowance charge.
    /// </summary>
    [IsoId("_cCSJY8NUEeWGDrnsYu2p6g")]
    [DisplayName("Actual Amount")]
    [IsoXmlTag("ActlAmt")]
    public CurrencyAndAmount? ActualAmount { get; init; } 
    
    /// <summary>
    /// Quantity on which this allowance charge is based.
    /// </summary>
    [IsoId("_cCSJZcNUEeWGDrnsYu2p6g")]
    [DisplayName("Basis Quantity")]
    [IsoXmlTag("BsisQty")]
    public Quantity10? BasisQuantity { get; init; } 
    
    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    [IsoId("_cCSJZ8NUEeWGDrnsYu2p6g")]
    [DisplayName("Calculation Percent")]
    [IsoXmlTag("ClctnPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculationPercent { get; init; } 
    
    /// <summary>
    /// Specifies the order in which the allowance or charge is applied.
    /// </summary>
    [IsoId("_cCSJacNUEeWGDrnsYu2p6g")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Reason, expressed as text, for this allowance charge.
    /// </summary>
    [IsoId("_cCSJa8NUEeWGDrnsYu2p6g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public DiscountOrChargeType1Choice_? Reason { get; init; } 
    
    
    #nullable disable
    
}
