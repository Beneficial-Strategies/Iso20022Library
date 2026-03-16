// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Portfolio Transfer13.
/// </summary>
[IsoId("_BzkVIT6XEe-N3-3e5ejJAw")]
[DisplayName("Portfolio Transfer13")]
public partial record PortfolioTransfer13
{
    #nullable enable

    /// <summary>
    /// Actual Transfer Date.
    /// </summary>
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    public IsoISODate? ActualTransferDate { get; init; } 

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// All Other Cash.
    /// </summary>
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public ValueList<AllOtherCash1> AllOtherCash { get; init; } = [];

    /// <summary>
    /// Cash All.
    /// </summary>
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public ValueList<CashAll1> CashAll { get; init; } = [];

    /// <summary>
    /// Financial Instrument Asset For Transfer.
    /// </summary>
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument105> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Master Reference.
    /// </summary>
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; } 

    /// <summary>
    /// Payment Details.
    /// </summary>
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument20? PaymentDetails { get; init; } 

    /// <summary>
    /// Portfolio.
    /// </summary>
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice_? Portfolio { get; init; } 

    /// <summary>
    /// Residual Cash.
    /// </summary>
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash2> ResidualCash { get; init; } = [];

    /// <summary>
    /// Tax Date.
    /// </summary>
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    public IsoISODate? TaxDate { get; init; } 

    /// <summary>
    /// Transfer Completion Identification.
    /// </summary>
    [DisplayName("Transfer Completion Identification")]
    [IsoXmlTag("TrfCmpltnId")]
    public required IsoMax35Text TransferCompletionIdentification { get; init; } 

    /// <summary>
    /// Transfer Instruction Reference.
    /// </summary>
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    public required IsoMax35Text TransferInstructionReference { get; init; } 

    
    #nullable disable
    
}
