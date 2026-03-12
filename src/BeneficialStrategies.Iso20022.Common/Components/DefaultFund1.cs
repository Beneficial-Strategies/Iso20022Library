// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information such as the default fund account identification or the default fund amount.
/// </summary>
[IsoId("_UqpvS9p-Ed-ak6NoX_4Aeg_1890910429")]
[DisplayName("Default Fund")]
public partial record DefaultFund1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the account identification of the clearing member at the ICSD (International Central Securities Depository) or at the central bank.
    /// </summary>
    [IsoId("_UqpvTNp-Ed-ak6NoX_4Aeg_82468307")]
    [DisplayName("Default Fund Account")]
    [IsoXmlTag("DfltFndAcct")]
    public required AccountIdentification4Choice_ DefaultFundAccount { get; init; } 
    
    /// <summary>
    /// Total amount required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UqpvTdp-Ed-ak6NoX_4Aeg_107176358")]
    [DisplayName("Total Default Fund Amount")]
    [IsoXmlTag("TtlDfltFndAmt")]
    public required ActiveCurrencyAndAmount TotalDefaultFundAmount { get; init; } 
    
    /// <summary>
    /// Provides details about the contribution to the default fund by trading venues/products.
    /// </summary>
    [IsoId("_UqzgQNp-Ed-ak6NoX_4Aeg_-799365417")]
    [DisplayName("Contribution")]
    [IsoXmlTag("Cntrbtn")]
    public Contribution1? Contribution { get; init; } 
    
    /// <summary>
    /// Additional amount that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on central counterparty specific criteria.
    /// </summary>
    [IsoId("_UqzgQdp-Ed-ak6NoX_4Aeg_1324320952")]
    [DisplayName("Increase Coverage Amount")]
    [IsoXmlTag("IncrCvrgAmt")]
    public ActiveCurrencyAndAmount? IncreaseCoverageAmount { get; init; } 
    
    
    #nullable disable
    
}
