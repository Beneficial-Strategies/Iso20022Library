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
[IsoId("_cbqJ5Ti8Eeydid5dcNPKvg")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails62
{
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_cbqJ7Ti8Eeydid5dcNPKvg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric5Choice_? Priority { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_cbqJ9Ti8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity36Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Number identifying a securities sub balance type (for example, restriction identification etc…).
    /// </summary>
    [IsoId("_cbqJ_Ti8Eeydid5dcNPKvg")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_cbqJ_zi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_cbqKBzi8Eeydid5dcNPKvg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown6 BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_cbqKDzi8Eeydid5dcNPKvg")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown6 BalanceTo { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    [IsoId("_cbqKFzi8Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; }
}
