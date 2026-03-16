// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Instruction Data2.
/// </summary>
[IsoId("_Wj4oIRA4Ee6N57R8Wekj-w")]
[DisplayName("Order Instruction Data2")]
public partial record OrderInstructionData2
{
    #nullable enable

    /// <summary>
    /// Buy Sell Indicator.
    /// </summary>
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public Side6Code? BuySellIndicator { get; init; } 

    /// <summary>
    /// Displayed Quantity.
    /// </summary>
    [DisplayName("Displayed Quantity")]
    [IsoXmlTag("DispdQty")]
    public FinancialInstrumentQuantity25Choice_? DisplayedQuantity { get; init; } 

    /// <summary>
    /// Initial Quantity.
    /// </summary>
    [DisplayName("Initial Quantity")]
    [IsoXmlTag("InitlQty")]
    public FinancialInstrumentQuantity25Choice_? InitialQuantity { get; init; } 

    /// <summary>
    /// Minimum Acceptable Quantity.
    /// </summary>
    [DisplayName("Minimum Acceptable Quantity")]
    [IsoXmlTag("MinAccptblQty")]
    public FinancialInstrumentQuantity25Choice_? MinimumAcceptableQuantity { get; init; } 

    /// <summary>
    /// Minimum Executable.
    /// </summary>
    [DisplayName("Minimum Executable")]
    [IsoXmlTag("MinExctbl")]
    public MinimumExecutable1? MinimumExecutable { get; init; } 

    /// <summary>
    /// Order Status.
    /// </summary>
    [DisplayName("Order Status")]
    [IsoXmlTag("OrdrSts")]
    public ValueList<OrderStatus11Code> OrderStatus { get; init; } = [];

    /// <summary>
    /// Order Validity Status.
    /// </summary>
    [DisplayName("Order Validity Status")]
    [IsoXmlTag("OrdrVldtySts")]
    public OrderStatus10Code? OrderValidityStatus { get; init; } 

    /// <summary>
    /// Passive Only Indicator.
    /// </summary>
    [DisplayName("Passive Only Indicator")]
    [IsoXmlTag("PssvOnlyInd")]
    public IsoTrueFalseIndicator? PassiveOnlyIndicator { get; init; } 

    /// <summary>
    /// Remaining Quantity.
    /// </summary>
    [DisplayName("Remaining Quantity")]
    [IsoXmlTag("RmngQty")]
    public FinancialInstrumentQuantity25Choice_? RemainingQuantity { get; init; } 

    /// <summary>
    /// Routing Strategy.
    /// </summary>
    [DisplayName("Routing Strategy")]
    [IsoXmlTag("RtgStrtgy")]
    public IsoMax50Text? RoutingStrategy { get; init; } 

    /// <summary>
    /// Self Execution Prevention.
    /// </summary>
    [DisplayName("Self Execution Prevention")]
    [IsoXmlTag("SlfExctnPrvntn")]
    public IsoTrueFalseIndicator? SelfExecutionPrevention { get; init; } 

    
    #nullable disable
    
}
