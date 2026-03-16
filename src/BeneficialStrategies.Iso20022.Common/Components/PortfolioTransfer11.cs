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
[IsoId("_XqDlJelqEeuvhrZwLF0fDg")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer11
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_X_g3w-lqEeuvhrZwLF0fDg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_X_g3xelqEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_X_g3x-lqEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Date for which the instructing party requests the transfer of the portfolio as a whole.
    /// </summary>
    [IsoId("_X_g3yelqEeuvhrZwLF0fDg")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_X_g3y-lqEeuvhrZwLF0fDg")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio8Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_X_g3zelqEeuvhrZwLF0fDg")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies whether all assets in the portfolio are to be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_X_g3z-lqEeuvhrZwLF0fDg")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public CashAll1? CashAll { get; init; }

    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with.
    /// </summary>
    [IsoId("_X_g30elqEeuvhrZwLF0fDg")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash2? ResidualCash { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_X_g30-lqEeuvhrZwLF0fDg")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_X_g31elqEeuvhrZwLF0fDg")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument102? FinancialInstrumentAssetForTransfer { get; init; }

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_X_g31-lqEeuvhrZwLF0fDg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
