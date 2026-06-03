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
[IsoId("12972603-34c9-4b91-abb7-ae1817c19c86")]
[DisplayName("Portfolio Transfer15")]
public record PortfolioTransfer15
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("fc010481-f9b8-4211-b23a-d8bc92ecc158")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("6ec1beee-76ca-447f-b521-f4405a312096")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    public required IsoMax35Text TransferInstructionReference { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("937847c8-d44f-43ea-b1ad-9b9191de5573")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    [IsoId("7c34b54d-9611-45cf-b6b8-2bfec860bf65")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    public IsoISODate? ActualTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("36015d10-d8b2-4291-8592-bdb56347e56e")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("be66d0fc-e2b2-4276-8443-f250423f9602")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public ValueList<AllOtherCash1> AllOtherCash { get; init; } = [];

    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("194ab330-a2c9-4b20-965d-b11e94c81e84")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public ValueList<CashAll1> CashAll { get; init; } = [];

    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with.
    /// </summary>
    [IsoId("060f283f-d86c-4cbe-85fd-9906dcf8b198")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash2> ResidualCash { get; init; } = [];

    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("529df0fa-9d34-4ebe-84a8-e611c0afd192")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("6d00ccf6-4d92-4719-b071-1dc99354261c")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument22? PaymentDetails { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("caf98572-e5e2-4dbd-b6e1-087c3703e96f")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument109> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("0901de8d-b622-4945-bdd5-b39894fc28a9")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
