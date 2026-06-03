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
[IsoId("2984a688-e9d8-4f03-990e-ce721af75b18")]
[DisplayName("Portfolio Transfer18")]
public record PortfolioTransfer18
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("142aa6f1-ba69-43d7-a385-bcaebc4d10f2")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("dad722ec-de93-4047-bdda-9501c5cf662a")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    public required IsoMax35Text TransferInstructionReference { get; init; }

    /// <summary>
    /// Identification of the completion assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("19cb5e03-6e9b-47fe-834c-8f6230d89d8f")]
    [DisplayName("Transfer Completion Identification")]
    [IsoXmlTag("TrfCmpltnId")]
    public required IsoMax35Text TransferCompletionIdentification { get; init; }

    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    [IsoId("425554a3-ec70-4095-b08d-3096601d2185")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    public IsoISODate? ActualTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("93676504-5bfc-44be-852a-7e52b18fbbaf")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("df217b38-7074-49fb-abed-c08e1c1f9c2c")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public ValueList<AllOtherCash1> AllOtherCash { get; init; } = [];

    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("dc2f3aed-2063-4a70-be1c-5c8250ca54ce")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public ValueList<CashAll1> CashAll { get; init; } = [];

    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with.
    /// </summary>
    [IsoId("6668440b-51d7-403d-bf9f-1a4ccfa6a9f7")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash2> ResidualCash { get; init; } = [];

    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("c4f23824-69bc-4d2f-aac4-92f7411846c4")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("dbc9700e-6304-4b25-abb1-97f1d1401b64")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument21? PaymentDetails { get; init; }

    /// <summary>
    /// Asset transferred.
    /// </summary>
    [IsoId("47772322-15d2-48df-b0a4-0531a3192a7a")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument112> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("d61901f4-fa0e-4180-beb9-a5fb1362924b")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
