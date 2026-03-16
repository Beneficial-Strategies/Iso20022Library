// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Foreign Exchange Terms41.
/// </summary>
[IsoId("_kv_c9Zt3Ee-wQIOX0djF2w")]
[DisplayName("Foreign Exchange Terms41")]
public partial record ForeignExchangeTerms41
{
    #nullable enable

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoBaseOne14Rate ExchangeRate { get; init; } 

    /// <summary>
    /// Quoted Currency.
    /// </summary>
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 

    /// <summary>
    /// Resulting Amount.
    /// </summary>
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required RestrictedFINActiveCurrencyAndAmount ResultingAmount { get; init; } 

    /// <summary>
    /// Unit Currency.
    /// </summary>
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveCurrencyCode UnitCurrency { get; init; } 

    
    #nullable disable
    
}
