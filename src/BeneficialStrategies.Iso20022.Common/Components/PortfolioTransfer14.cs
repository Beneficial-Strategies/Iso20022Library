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
[IsoId("bbf72b05-1174-4003-81ca-21f41f0b81f7")]
[DisplayName("Portfolio Transfer14")]
public record PortfolioTransfer14
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("4dca764a-5743-4d20-b854-242e4976102d")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("2b0bc97a-f931-443b-857c-18472fddc0d4")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("70fc8d68-0c7b-41d9-a34e-f95337bf72e6")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Date for which the instructing party requests the transfer of the portfolio as a whole.
    /// </summary>
    [IsoId("8383f1d0-c007-46a8-9706-f3db807a1be0")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public IsoISODate? RequestedTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("1aee86f8-fbd1-4317-b5a3-5b245972c50f")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio8Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("06ec01a4-77af-467d-b14c-823fb87e259a")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public ValueList<AllOtherCash1> AllOtherCash { get; init; } = [];

    /// <summary>
    /// Specifies whether all assets in the portfolio are to be liquidated and transferred as cash.
    /// </summary>
    [IsoId("576efe5d-4a14-4982-9746-96334717a9dc")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public ValueList<CashAll1> CashAll { get; init; } = [];

    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with.
    /// </summary>
    [IsoId("10dbc33c-9ce5-47cc-a0c2-c121a941b2eb")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash2> ResidualCash { get; init; } = [];

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("65f4600d-3522-46b2-b211-7c28f0da2a16")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument22? PaymentDetails { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("11f297ce-83f2-444e-bfaf-4b787c839216")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument108> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("5b57cfff-d8a2-4017-a359-3c6f7eca94d6")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
