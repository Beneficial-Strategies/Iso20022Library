// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Position Details65.
/// </summary>
[IsoId("_m1CtgYybEe-PVZsedaAGaA")]
[DisplayName("Intra Position Details65")]
public partial record IntraPositionDetails65
{
    #nullable enable

    /// <summary>
    /// Available Date.
    /// </summary>
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 

    /// <summary>
    /// Balance From.
    /// </summary>
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown5 BalanceFrom { get; init; } 

    /// <summary>
    /// Balance To.
    /// </summary>
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown5 BalanceTo { get; init; } 

    /// <summary>
    /// Collateral Monitor Amount.
    /// </summary>
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 

    /// <summary>
    /// Corporate Action Event Type.
    /// </summary>
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType110Choice_? CorporateActionEventType { get; init; } 

    /// <summary>
    /// Instruction Processing Additional Details.
    /// </summary>
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 

    /// <summary>
    /// Previously Settled Quantity.
    /// </summary>
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity33Choice_? PreviouslySettledQuantity { get; init; } 

    /// <summary>
    /// Remaining To Be Settled Quantity.
    /// </summary>
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity33Choice_? RemainingToBeSettledQuantity { get; init; } 

    /// <summary>
    /// Securities Sub Balance Identification.
    /// </summary>
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 

    /// <summary>
    /// Settled Quantity.
    /// </summary>
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity33Choice_ SettledQuantity { get; init; } 

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 

    
    #nullable disable
    
}
