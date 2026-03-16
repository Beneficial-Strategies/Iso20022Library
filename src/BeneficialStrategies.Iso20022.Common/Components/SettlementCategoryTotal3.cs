// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Category Total3.
/// </summary>
[IsoId("_stLFMZjJEe6OBt2eQPMPsQ")]
[DisplayName("Settlement Category Total3")]
public partial record SettlementCategoryTotal3
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; } 

    /// <summary>
    /// Count.
    /// </summary>
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public IsoNumber? Count { get; init; } 

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; } 

    /// <summary>
    /// Interchange Fee Amount.
    /// </summary>
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public ImpliedCurrencyAndAmount? InterchangeFeeAmount { get; init; } 

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

    /// <summary>
    /// Processing Fee Amount.
    /// </summary>
    [DisplayName("Processing Fee Amount")]
    [IsoXmlTag("PrcgFeeAmt")]
    public ImpliedCurrencyAndAmount? ProcessingFeeAmount { get; init; } 

    /// <summary>
    /// Processing Fee Credit Debit.
    /// </summary>
    [DisplayName("Processing Fee Credit Debit")]
    [IsoXmlTag("PrcgFeeCdtDbt")]
    public CreditDebit3Code? ProcessingFeeCreditDebit { get; init; } 

    /// <summary>
    /// Processing Fee Currency.
    /// </summary>
    [DisplayName("Processing Fee Currency")]
    [IsoXmlTag("PrcgFeeCcy")]
    public ISO3NumericCurrencyCode? ProcessingFeeCurrency { get; init; } 

    
    #nullable disable
    
}
