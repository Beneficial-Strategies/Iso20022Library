// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
[IsoId("_C5dKU4fuEeevKP8c-ilVhA")]
[DisplayName("ISA Transfer")]
public record ISATransfer29
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_DKaXY4fuEeevKP8c-ilVhA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_DKaXZYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_DKaXZ4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_DKaXaYfuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_DKaXa4fuEeevKP8c-ilVhA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference8? CounterpartyReference { get; init; }

    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_DKaXbYfuEeevKP8c-ilVhA")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_DKaXb4fuEeevKP8c-ilVhA")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }

    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_DKaXcYfuEeevKP8c-ilVhA")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public ISAPortfolio1Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_DKaXc4fuEeevKP8c-ilVhA")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_DKaXdYfuEeevKP8c-ilVhA")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_DKaXd4fuEeevKP8c-ilVhA")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument60> FinancialInstrumentAssetForTransfer { get; init; } = [];
}
