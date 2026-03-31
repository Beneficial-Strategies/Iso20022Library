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
[IsoId("_n_YKkZNBEemQB_8XA98K0Q")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer8
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_oUNLFZNBEemQB_8XA98K0Q")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_oUNLF5NBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_oUNLGZNBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Date for which the instructing party requests the transfer of the portfolio as a whole.
    /// </summary>
    [IsoId("_oUNLG5NBEemQB_8XA98K0Q")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_oUNLHZNBEemQB_8XA98K0Q")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio6Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_oUNLH5NBEemQB_8XA98K0Q")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public ValueList<AllOtherCash1> AllOtherCash { get; init; } = [];

    /// <summary>
    /// Specifies whether all assets in the portfolio are to be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_oUNLIZNBEemQB_8XA98K0Q")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public ValueList<CashAll1> CashAll { get; init; } = [];

    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with.
    /// </summary>
    [IsoId("_oUNLI5NBEemQB_8XA98K0Q")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash2> ResidualCash { get; init; } = [];

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_oUNLJZNBEemQB_8XA98K0Q")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_oUNLJ5NBEemQB_8XA98K0Q")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument86> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_oUNLKZNBEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
