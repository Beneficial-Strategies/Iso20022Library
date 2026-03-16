// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other Amount5.
/// </summary>
[IsoId("_CN_OIY1MEe6S0_1AaJzQCA")]
[DisplayName("Other Amount5")]
public partial record OtherAmount5
{
    #nullable enable

    /// <summary>
    /// Agent Fee Amount.
    /// </summary>
    [DisplayName("Agent Fee Amount")]
    [IsoXmlTag("AgtFeeAmt")]
    public required ImpliedCurrencyAndAmount AgentFeeAmount { get; init; } 

    /// <summary>
    /// Agent Fee Credit Debit.
    /// </summary>
    [DisplayName("Agent Fee Credit Debit")]
    [IsoXmlTag("AgtFeeCdtDbt")]
    public CreditDebit3Code? AgentFeeCreditDebit { get; init; } 

    /// <summary>
    /// Agent Fee Currency.
    /// </summary>
    [DisplayName("Agent Fee Currency")]
    [IsoXmlTag("AgtFeeCcy")]
    public ISO3NumericCurrencyCode? AgentFeeCurrency { get; init; } 

    /// <summary>
    /// Clearing Amount.
    /// </summary>
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public required ImpliedCurrencyAndAmount ClearingAmount { get; init; } 

    /// <summary>
    /// Clearing Count.
    /// </summary>
    [DisplayName("Clearing Count")]
    [IsoXmlTag("ClrCnt")]
    public required IsoNumber ClearingCount { get; init; } 

    /// <summary>
    /// Clearing Credit Debit.
    /// </summary>
    [DisplayName("Clearing Credit Debit")]
    [IsoXmlTag("ClrCdtDbt")]
    public CreditDebit3Code? ClearingCreditDebit { get; init; } 

    /// <summary>
    /// Clearing Currency.
    /// </summary>
    [DisplayName("Clearing Currency")]
    [IsoXmlTag("ClrCcy")]
    public ISO3NumericCurrencyCode? ClearingCurrency { get; init; } 

    /// <summary>
    /// Interchange Fee Amount.
    /// </summary>
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public required ImpliedCurrencyAndAmount InterchangeFeeAmount { get; init; } 

    /// <summary>
    /// Interchange Fee Credit Debit.
    /// </summary>
    [DisplayName("Interchange Fee Credit Debit")]
    [IsoXmlTag("IntrchngFeeCdtDbt")]
    public CreditDebit3Code? InterchangeFeeCreditDebit { get; init; } 

    /// <summary>
    /// Interchange Fee Currency.
    /// </summary>
    [DisplayName("Interchange Fee Currency")]
    [IsoXmlTag("IntrchngFeeCcy")]
    public ISO3NumericCurrencyCode? InterchangeFeeCurrency { get; init; } 

    
    #nullable disable
    
}
