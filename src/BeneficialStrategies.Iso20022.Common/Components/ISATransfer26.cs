// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("__BBKKyPvEeWQjryFgN2ITg")]
[DisplayName("ISA Transfer")]
public record ISATransfer26
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("__eeiAyPvEeWQjryFgN2ITg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("__eeiBSPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of asset, typically assigned by the transferee.
    /// </summary>
    [IsoId("__eeiByPvEeWQjryFgN2ITg")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferInstructionReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_iSQ_wCYOEeWJkOUkQWu90g")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference7? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_iSQ_wSYOEeWJkOUkQWu90g")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference7? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_zvfroSYOEeWJkOUkQWu90g")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Date when the transfer instruction was executed.
    /// </summary>
    [IsoId("__eeiCSPvEeWQjryFgN2ITg")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActualTransferDate { get; init; }

    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("__eeiCyPvEeWQjryFgN2ITg")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; }

    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("__eeiDSPvEeWQjryFgN2ITg")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public ISAPortfolio2Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("__eeiDyPvEeWQjryFgN2ITg")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("__eeiESPvEeWQjryFgN2ITg")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument48> FinancialInstrumentAssetForTransfer { get; init; } = [];
}
