// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_P8A169p-Ed-ak6NoX_4Aeg_-2006005591")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation30
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify a cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_P8A17Np-Ed-ak6NoX_4Aeg_-2006005560")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("_P8A17dp-Ed-ak6NoX_4Aeg_1037983350")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case2? Case { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P8A17tp-Ed-ak6NoX_4Aeg_-2006005446")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P8A179p-Ed-ak6NoX_4Aeg_-2006005384")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [IsoId("_P8A18Np-Ed-ak6NoX_4Aeg_-2006005045")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_P8A18dp-Ed-ak6NoX_4Aeg_232673400")]
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_P8J_0Np-Ed-ak6NoX_4Aeg_232673091")]
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_P8J_0dp-Ed-ak6NoX_4Aeg_-2005084919")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<CancellationReasonInformation3> CancellationReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P8J_0tp-Ed-ak6NoX_4Aeg_-2006004951")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; }
}
