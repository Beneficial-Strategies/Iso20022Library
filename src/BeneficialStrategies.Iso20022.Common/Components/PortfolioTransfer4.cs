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
[IsoId("_13HFwU3kEeiQHa-q1Uephw")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer4
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_2I9qw03kEeiQHa-q1Uephw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_2I9qx03kEeiQHa-q1Uephw")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferInstructionReference { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_2I9qxU3kEeiQHa-q1Uephw")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    [IsoId("_2I9qz03kEeiQHa-q1Uephw")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActualTransferDate { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_2I9q003kEeiQHa-q1Uephw")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio2Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_2I9q1U3kEeiQHa-q1Uephw")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_06uIwc4GEeiAhd-njDxLnA")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public CashAll1Code? CashAll { get; init; }

    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_2I9q0U3kEeiQHa-q1Uephw")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; }

    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_t5W-4aFQEei_VZq-6SQkuQ")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Zxdf0Vj_EeiaQoK2-_0KTA")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_2I9q103kEeiQHa-q1Uephw")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument70> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_ZpTG8ZClEeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
