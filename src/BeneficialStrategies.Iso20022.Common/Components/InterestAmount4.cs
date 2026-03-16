// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the elements related to the interest amount calculation.
/// </summary>
[IsoId("_AFlH0StNEeyOa655cLd-DQ")]
[DisplayName("Interest Amount")]
public record InterestAmount4
{
    /// <summary>
    /// Indicates whether the interest request is new or updated.
    /// </summary>
    [IsoId("_Ad3sAytNEeyOa655cLd-DQ")]
    [DisplayName("Interest Request Sequence")]
    [IsoXmlTag("IntrstReqSeq")]
    public required InterestRequestSequence1Code InterestRequestSequence { get; init; }

    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    [IsoId("_Ad3sBStNEeyOa655cLd-DQ")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriod2 InterestPeriod { get; init; }

    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_Ad3sBytNEeyOa655cLd-DQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; }

    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_Ad3sCStNEeyOa655cLd-DQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_Ad3sCytNEeyOa655cLd-DQ")]
    [DisplayName("Interest Method")]
    [IsoXmlTag("IntrstMtd")]
    public required InterestMethod1Code InterestMethod { get; init; }

    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_Ad3sDStNEeyOa655cLd-DQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate1Choice_? InterestRate { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_Ad3sDytNEeyOa655cLd-DQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethod2Code? DayCountBasis { get; init; }

    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Ad3sEStNEeyOa655cLd-DQ")]
    [DisplayName("Applied Withholding Tax")]
    [IsoXmlTag("ApldWhldgTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; }

    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    [IsoId("_Ad3sEytNEeyOa655cLd-DQ")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public CalculationMethod1Code? CalculationMethod { get; init; }

    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    [IsoId("_Ad3sFStNEeyOa655cLd-DQ")]
    [DisplayName("Calculation Frequency")]
    [IsoXmlTag("ClctnFrqcy")]
    public Frequency1Code? CalculationFrequency { get; init; }

    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    [IsoId("_Ad3sFytNEeyOa655cLd-DQ")]
    [DisplayName("Collateral Purpose")]
    [IsoXmlTag("CollPurp")]
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; }

    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_Ad3sGStNEeyOa655cLd-DQ")]
    [DisplayName("Opening Collateral Balance")]
    [IsoXmlTag("OpngCollBal")]
    public CollateralBalance1? OpeningCollateralBalance { get; init; }

    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_Ad3sGytNEeyOa655cLd-DQ")]
    [DisplayName("Closing Collateral Balance")]
    [IsoXmlTag("ClsgCollBal")]
    public required CollateralBalance1 ClosingCollateralBalance { get; init; }

    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_Ad3sHStNEeyOa655cLd-DQ")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    [IsoId("_Ad3sHytNEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional references linked to the updated interest payement request.
    /// </summary>
    [IsoId("_Ad3sIStNEeyOa655cLd-DQ")]
    [DisplayName("Reference Details")]
    [IsoXmlTag("RefDtls")]
    public Reference20? ReferenceDetails { get; init; }
}
