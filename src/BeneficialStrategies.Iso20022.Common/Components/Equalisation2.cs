// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performances fess at the end of a performance period.
/// </summary>
[IsoId("_TToR89p-Ed-ak6NoX_4Aeg_1031553059")]
[DisplayName("Equalisation")]
public partial record Equalisation2
{
    #nullable enable
    
    /// <summary>
    /// Amount of money resulting from the calculation of the equalisation.
    /// </summary>
    [IsoId("_TToR9Np-Ed-ak6NoX_4Aeg_1031553061")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Rate used for calculation of the equalisation.
    /// </summary>
    [IsoId("_TToR9dp-Ed-ak6NoX_4Aeg_1031553338")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Specifies if the amount is a debit (negative) or credit (positive) amount.
    /// </summary>
    [IsoId("_TToR9tp-Ed-ak6NoX_4Aeg_1115593872")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
