// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
[IsoId("_SVywtdp-Ed-ak6NoX_4Aeg_-1500373473")]
[DisplayName("Balance Amounts")]
public partial record BalanceAmounts3
{
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVywttp-Ed-ak6NoX_4Aeg_1018333172")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public AmountAndDirection6? HoldingValue { get; init; } 
    
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVywt9p-Ed-ak6NoX_4Aeg_-1905008584")]
    [DisplayName("Previous Holding Value")]
    [IsoXmlTag("PrvsHldgVal")]
    public AmountAndDirection6? PreviousHoldingValue { get; init; } 
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_SVywuNp-Ed-ak6NoX_4Aeg_1019253264")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection6? BookValue { get; init; } 
    
    /// <summary>
    /// Value of the position eligible for collateral purposes.
    /// </summary>
    [IsoId("_SV76oNp-Ed-ak6NoX_4Aeg_1019253419")]
    [DisplayName("Eligible Collateral Value")]
    [IsoXmlTag("ElgblCollVal")]
    public AmountAndDirection6? EligibleCollateralValue { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_SV76odp-Ed-ak6NoX_4Aeg_-611160519")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection6? AccruedInterestAmount { get; init; } 
    
    
    #nullable disable
    
}
