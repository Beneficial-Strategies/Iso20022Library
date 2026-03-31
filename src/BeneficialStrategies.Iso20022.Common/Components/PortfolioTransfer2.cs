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
[IsoId("_PWwCsU4CEeiQHa-q1Uephw")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer2
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Pm9o804CEeiQHa-q1Uephw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_Pm9o9U4CEeiQHa-q1Uephw")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_Pm9o904CEeiQHa-q1Uephw")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_Pm9o-04CEeiQHa-q1Uephw")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio2Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_Pm9o_U4CEeiQHa-q1Uephw")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_cjs6kc4GEeiAhd-njDxLnA")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public CashAll1Code? CashAll { get; init; }

    /// <summary>
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_Pm9o-U4CEeiQHa-q1Uephw")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; }

    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_ZZeaUaFQEei_VZq-6SQkuQ")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_Pm9o_04CEeiQHa-q1Uephw")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument68> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_VcKYIZClEeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
