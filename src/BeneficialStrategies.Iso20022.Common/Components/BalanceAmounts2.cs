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
[IsoId("_SVywsdp-Ed-ak6NoX_4Aeg_-1968542123")]
[DisplayName("Balance Amounts")]
public partial record BalanceAmounts2
{
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_SVywstp-Ed-ak6NoX_4Aeg_935214468")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public required AmountAndDirection6 HoldingValue { get; init; } 
    
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_SVyws9p-Ed-ak6NoX_4Aeg_935214776")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection6? BookValue { get; init; } 
    
    /// <summary>
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_SVywtNp-Ed-ak6NoX_4Aeg_935214846")]
    [DisplayName("Unrealised Gain Loss")]
    [IsoXmlTag("UrlsdGnLoss")]
    public AmountAndDirection6? UnrealisedGainLoss { get; init; } 
    
    
    #nullable disable
    
}
