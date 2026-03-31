// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[IsoId("_6ni-i5NLEeWGlc8L7oPDIg")]
[DisplayName("Settlement Type And Additional Parameters")]
public record SettlementTypeAndAdditionalParameters16
{
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_6ni-jZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_6ni-m5NLEeWGlc8L7oPDIg")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_6ni-qZNLEeWGlc8L7oPDIg")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CommonIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_6ni-sZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Indicates whether the settlement transaction was already sent on the market and that it is only sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    [IsoId("_6ni-uZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_6ni-wZNLEeWGlc8L7oPDIg")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_6ni-w5NLEeWGlc8L7oPDIg")]
    [DisplayName("Client Collateral Transaction Identification")]
    [IsoXmlTag("ClntCollTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClientCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_6ni-xZNLEeWGlc8L7oPDIg")]
    [DisplayName("Triparty Agent Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtCollTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? TripartyAgentCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    [IsoId("_6ni-x5NLEeWGlc8L7oPDIg")]
    [DisplayName("Triparty Collateral Instruction Identification")]
    [IsoXmlTag("TrptyCollInstrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? TripartyCollateralInstructionIdentification { get; init; }
}
