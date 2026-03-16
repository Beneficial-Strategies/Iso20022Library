// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging Line Item3.
/// </summary>
[IsoId("_3IKvQXTsEe6h-4AZRg9sVg")]
[DisplayName("Lodging Line Item3")]
public record LodgingLineItem3
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Post Check Out.
    /// </summary>
    [DisplayName("Post Check Out")]
    [IsoXmlTag("PstChckOut")]
    public IsoTrueFalseIndicator? PostCheckOut { get; init; }

    /// <summary>
    /// Sub Total Amount.
    /// </summary>
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LodgingService1Code? Type { get; init; }

    /// <summary>
    /// Unit Amount.
    /// </summary>
    [DisplayName("Unit Amount")]
    [IsoXmlTag("UnitAmt")]
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; }
}
