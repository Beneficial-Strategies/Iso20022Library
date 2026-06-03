// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging line item details.
/// </summary>
[IsoId("_6lyhoUh4EfCMZJtj4J7UGQ")]
[DisplayName("Lodging Line Item4")]
public record LodgingLineItem4
{
    /// <summary>
    /// Date of the charge for the product or service associated with the line item.
    /// </summary>
    [IsoId("_6psxQUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Time of the charge for the product or service associated with the line item.
    /// </summary>
    [IsoId("_6psxQ0h4EfCMZJtj4J7UGQ")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Type of product or service associated with the line item.
    /// </summary>
    [IsoId("_6psxRUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LodgingService1Code? Type { get; init; }

    /// <summary>
    /// Other type of product or service associated with the line item.
    /// </summary>
    [IsoId("_6psxR0h4EfCMZJtj4J7UGQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Indicates whether or not the charge originated following the checkout.
    /// </summary>
    [IsoId("_6psxSUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Post Check Out")]
    [IsoXmlTag("PstChckOut")]
    public IsoTrueFalseIndicator? PostCheckOut { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit.
    /// </summary>
    [IsoId("_6psxS0h4EfCMZJtj4J7UGQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Contains the cost for one unit of the product or service.
    /// </summary>
    [IsoId("_6psxTUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Unit Amount")]
    [IsoXmlTag("UnitAmt")]
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; }

    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_6psxT0h4EfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Subtotal amount of line item.
    /// </summary>
    [IsoId("_6psxUUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_6psxU0h4EfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_3uoHQkh4EfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_3uoHQ0h4EfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
