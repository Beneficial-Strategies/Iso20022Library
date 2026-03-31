// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_5Nc_A5NLEeWGlc8L7oPDIg")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails35
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_5Nc_CZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Number identifying a Securities Sub balance Type (example restriction identification etc…).
    /// </summary>
    [IsoId("_5Nc_EZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_5Nc_E5NLEeWGlc8L7oPDIg")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection55? CollateralMonitorAmount { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_5Nc_FZNLEeWGlc8L7oPDIg")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_5Nc_HZNLEeWGlc8L7oPDIg")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_5Nc_JZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_5Nc_LZNLEeWGlc8L7oPDIg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTimeChoice_? AvailableDate { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_5Nc_NZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType46Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_5Nc_PZNLEeWGlc8L7oPDIg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_5Nc_RZNLEeWGlc8L7oPDIg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceTo { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_5Nc_TZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; }
}
