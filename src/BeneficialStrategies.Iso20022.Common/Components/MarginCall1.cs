// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the margin call request.
/// </summary>
[IsoId("_Uk_MJdp-Ed-ak6NoX_4Aeg_138884862")]
[DisplayName("Margin Call")]
public record MarginCall1
{
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party A. That is, all transactions which would have an amount payable by party B to party A if they were being terminated.
    /// </summary>
    [IsoId("_Uk_MJtp-Ed-ak6NoX_4Aeg_-1579631561")]
    [DisplayName("Exposed Amount Party A")]
    [IsoXmlTag("XpsdAmtPtyA")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; }

    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party B. That is, all transactions which would have an amount payable by party A to party B if they were being terminated.
    /// </summary>
    [IsoId("_Uk_MJ9p-Ed-ak6NoX_4Aeg_1154819457")]
    [DisplayName("Exposed Amount Party B")]
    [IsoXmlTag("XpsdAmtPtyB")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; }

    /// <summary>
    /// Determines how the variation margin requirement is to be calculated:
    /// - either Net, in which the exposure of all transactions in favour of party A and the the exposure of all transactions in favour of party B will be netted together or
    /// - gross in which two separate variation margin requirements will be determined.
    /// </summary>
    [IsoId("_Uk_MKNp-Ed-ak6NoX_4Aeg_1509089912")]
    [DisplayName("Exposure Convention")]
    [IsoXmlTag("XpsrCnvntn")]
    public ExposureConventionType1Code? ExposureConvention { get; init; }

    /// <summary>
    /// Amount applied as an add-on to the exposure (to party A) usually intended to cover a possible increase in exposure before the next valuation date.
    /// </summary>
    [IsoId("_Uk_MKdp-Ed-ak6NoX_4Aeg_1988654401")]
    [DisplayName("Independent Amount Party A")]
    [IsoXmlTag("IndpdntAmtPtyA")]
    public AggregatedIndependentAmount1? IndependentAmountPartyA { get; init; }

    /// <summary>
    /// An amount applied as an add-on to the exposure (to party B) usually intended to cover a possible increase in exposure before the next valuation date.
    /// </summary>
    [IsoId("_UlI9INp-Ed-ak6NoX_4Aeg_-957268284")]
    [DisplayName("Independent Amount Party B")]
    [IsoXmlTag("IndpdntAmtPtyB")]
    public AggregatedIndependentAmount1? IndependentAmountPartyB { get; init; }

    /// <summary>
    /// Provides information like threshold amount, threshold type, minimum transfer amount, rouding amount or rounding convention, that applies to either the variation margin or the segregated independent amount.
    /// </summary>
    [IsoId("_UlI9Idp-Ed-ak6NoX_4Aeg_1932695356")]
    [DisplayName("Margin Terms")]
    [IsoXmlTag("MrgnTerms")]
    public MarginTerms1Choice_? MarginTerms { get; init; }

    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties with a segregation between variation margin and segregated independent amount.
    /// </summary>
    [IsoId("_UlI9Itp-Ed-ak6NoX_4Aeg_-381594311")]
    [DisplayName("Collateral Balance")]
    [IsoXmlTag("CollBal")]
    public CollateralBalance1Choice_? CollateralBalance { get; init; }
}
