// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the calculation of the margin.
/// </summary>
[IsoId("_UkjHSdp-Ed-ak6NoX_4Aeg_-647501406")]
[DisplayName("Margin")]
public partial record Margin2
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_UkjHStp-Ed-ak6NoX_4Aeg_-2041966150")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Net total of the transaction exposure of all outstanding deals.
    /// </summary>
    [IsoId("_UksRMNp-Ed-ak6NoX_4Aeg_-329577950")]
    [DisplayName("Exposure Amount")]
    [IsoXmlTag("XpsrAmt")]
    public Amount2? ExposureAmount { get; init; } 
    
    /// <summary>
    /// Total margin requirement (expressed in the reporting currency) that must be provided by the clearing member to the central counterparty. This is the total requirement calculated to cover the initial margin and the variation margin.
    /// </summary>
    [IsoId("_UksRMdp-Ed-ak6NoX_4Aeg_-1135141434")]
    [DisplayName("Total Margin Amount")]
    [IsoXmlTag("TtlMrgnAmt")]
    public required ActiveCurrencyAndAmount TotalMarginAmount { get; init; } 
    
    /// <summary>
    /// Provides details on the calculation of the variation margin.
    /// </summary>
    [IsoId("_UksRMtp-Ed-ak6NoX_4Aeg_177061771")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required VariationMargin2 VariationMargin { get; init; } 
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// </summary>
    [IsoId("_UksRM9p-Ed-ak6NoX_4Aeg_2010627762")]
    [DisplayName("Initial Margin")]
    [IsoXmlTag("InitlMrgn")]
    public required Amount2 InitialMargin { get; init; } 
    
    /// <summary>
    /// Additional amount (expressed in the reporting currency) that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on Central counterparty specific criteria.
    /// </summary>
    [IsoId("_UksRNNp-Ed-ak6NoX_4Aeg_2025633151")]
    [DisplayName("Increase Coverage")]
    [IsoXmlTag("IncrCvrg")]
    public ActiveCurrencyAndAmount? IncreaseCoverage { get; init; } 
    
    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the Central counterparty.
    /// </summary>
    [IsoId("_UksRNdp-Ed-ak6NoX_4Aeg_499679229")]
    [DisplayName("Minimum Requirement Deposit")]
    [IsoXmlTag("MinRqrmntDpst")]
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_UksRNtp-Ed-ak6NoX_4Aeg_1252170489")]
    [DisplayName("Collateral On Deposit")]
    [IsoXmlTag("CollOnDpst")]
    public Collateral3? CollateralOnDeposit { get; init; } 
    
    /// <summary>
    /// Provides details on the margin result.
    /// </summary>
    [IsoId("_UksRN9p-Ed-ak6NoX_4Aeg_1717019535")]
    [DisplayName("Margin Result")]
    [IsoXmlTag("MrgnRslt")]
    public MarginResult1Choice_? MarginResult { get; init; } 
    
    
    #nullable disable
    
}
