// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the valuation details per exposure type aggregation.
/// </summary>
[IsoId("_Ml-goSs9EeySlt9bF77XfA")]
[DisplayName("Exposure Type Aggregation")]
public partial record ExposureTypeAggregation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_M90Y0Ss9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; } 
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_M90Y0ys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    [IsoXmlTag("SttlmPrc")]
    public GenericIdentification30? SettlementProcess { get; init; } 
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_M90Y1Ss9EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public ValueList<CollateralAmount16> ValuationAmounts { get; init; } = [];
    // ID for the above is _M90Y1Ss9EeySlt9bF77XfA
    
    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_M90Y1ys9EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRate { get; init; } 
    
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions of the same exposure type.
    /// </summary>
    [IsoId("_M90Y2Ss9EeySlt9bF77XfA")]
    [DisplayName("Global Exposure Type Status")]
    [IsoXmlTag("GblXpsrTpSts")]
    public CollateralStatus1Code? GlobalExposureTypeStatus { get; init; } 
    
    
    #nullable disable
    
}
