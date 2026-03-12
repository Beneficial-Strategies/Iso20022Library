// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_PVH1Btp-Ed-ak6NoX_4Aeg_-819454093")]
[DisplayName("Currency And Amount Range")]
public partial record CurrencyAndAmountRange
{
    #nullable enable
    
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    [IsoId("_PVH1B9p-Ed-ak6NoX_4Aeg_-819454076")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAmountRangeChoice_ Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    [IsoId("_PVH1CNp-Ed-ak6NoX_4Aeg_-819453849")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    [IsoId("_PVQ-8Np-Ed-ak6NoX_4Aeg_-819454075")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; } 
    
    
    #nullable disable
    
}
