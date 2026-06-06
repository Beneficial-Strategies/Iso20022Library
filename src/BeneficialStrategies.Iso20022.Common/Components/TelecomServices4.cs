// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services purchase data.
/// </summary>
[IsoId("_mkgbEUhsEfCMZJtj4J7UGQ")]
[DisplayName("Telecom Services4")]
public record TelecomServices4
{
    /// <summary>
    /// Customer account number with the service provider.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-cacn")]
    [DisplayName("Customer Account Number")]
    [IsoXmlTag("CstmrAcctNb")]
    public IsoMax35Text? CustomerAccountNumber { get; init; }

    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-csnm")]
    [DisplayName("Customer Name")]
    [IsoXmlTag("CstmrNm")]
    public IsoMax105Text? CustomerName { get; init; }

    /// <summary>
    /// Customer's primary contact phone number.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-cspn")]
    [DisplayName("Customer Phone")]
    [IsoXmlTag("CstmrPhne")]
    public IsoPhoneNumber? CustomerPhone { get; init; }

    /// <summary>
    /// Contains the billing period start date for telecommunication or related services.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blst")]
    [DisplayName("Billing Start")]
    [IsoXmlTag("BlgStart")]
    public IsoISODate? BillingStart { get; init; }

    /// <summary>
    /// Contains the billing period end date for telecommunication or related services.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blen")]
    [DisplayName("Billing End")]
    [IsoXmlTag("BlgEnd")]
    public IsoISODate? BillingEnd { get; init; }

    /// <summary>
    /// Summary of the charges associated with the billing event.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blev")]
    [DisplayName("Billing Event")]
    [IsoXmlTag("BlgEvt")]
    public ValueList<TelecomBillingEventAmount1> BillingEvent { get; init; } = [];

    /// <summary>
    /// Total of taxes applicable to the billing amount.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ttlx")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax44> TotalTax { get; init; } = [];

    /// <summary>
    /// Total amount includes amounts of all the billing events and total tax amounts.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ttla")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Telecom Services Line Item component is designed to carry detail level telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-lnit")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<TelecomServicesLineItem4> LineItem { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
