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
[IsoId("__2vvIfFUEee_LsXdoqzkWg")]
[DisplayName("Line Item Allowance Charge")]
public partial record LineItemAllowanceCharge3
{
    #nullable enable
    
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    [IsoId("___vTEfFUEee_LsXdoqzkWg")]
    [DisplayName("Charge Indicator")]
    [IsoXmlTag("ChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargeIndicator { get; init; } 
    
    /// <summary>
    /// Actual monetary value of this allowance charge.
    /// </summary>
    [IsoId("___vTE_FUEee_LsXdoqzkWg")]
    [DisplayName("Actual Amount")]
    [IsoXmlTag("ActlAmt")]
    public CurrencyAndAmount? ActualAmount { get; init; } 
    
    /// <summary>
    /// Quantity on which this allowance charge is based.
    /// </summary>
    [IsoId("___vTFfFUEee_LsXdoqzkWg")]
    [DisplayName("Basis Quantity")]
    [IsoXmlTag("BsisQty")]
    public Quantity16? BasisQuantity { get; init; } 
    
    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    [IsoId("___vTF_FUEee_LsXdoqzkWg")]
    [DisplayName("Calculation Percent")]
    [IsoXmlTag("ClctnPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CalculationPercent { get; init; } 
    
    /// <summary>
    /// Specifies the order in which the allowance or charge is applied.
    /// </summary>
    [IsoId("___vTGfFUEee_LsXdoqzkWg")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Reason, expressed as text, for this allowance charge.
    /// </summary>
    [IsoId("___vTG_FUEee_LsXdoqzkWg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public DiscountOrChargeType1Choice_? Reason { get; init; } 
    
    
    #nullable disable
    
}
