// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_UGTFC9p-Ed-ak6NoX_4Aeg_1927466067")]
[DisplayName("Securities Option")]
public partial record SecuritiesOption2
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_UGcO8Np-Ed-ak6NoX_4Aeg_1927466137")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Quantity instructed to be received over and above normal ensured entitlement.
    /// </summary>
    [IsoId("_UGcO8dp-Ed-ak6NoX_4Aeg_1927466379")]
    [DisplayName("Over And Above Normal Ensured Entitlement Quantity")]
    [IsoXmlTag("OverAndAbovNrmlNsrdEntitlmntQty")]
    public FinancialInstrumentQuantity1Choice_? OverAndAboveNormalEnsuredEntitlementQuantity { get; init; } 
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is a quantity of securities instructed or a quantity to receive.
    /// </summary>
    [IsoId("_UGcO8tp-Ed-ak6NoX_4Aeg_-1537787480")]
    [DisplayName("Instructed Or Quantity To Receive")]
    [IsoXmlTag("InstdOrQtyToRcv")]
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    
    
    #nullable disable
    
}
