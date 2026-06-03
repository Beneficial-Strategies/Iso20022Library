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
    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-cacn")]
    [DisplayName("Customer Account Number")]
    [IsoXmlTag("CstmrAcctNb")]
    public IsoMax35Text? CustomerAccountNumber { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-csnm")]
    [DisplayName("Customer Name")]
    [IsoXmlTag("CstmrNm")]
    public IsoMax105Text? CustomerName { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-cspn")]
    [DisplayName("Customer Phone")]
    [IsoXmlTag("CstmrPhne")]
    public IsoPhoneNumber? CustomerPhone { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blst")]
    [DisplayName("Billing Start")]
    [IsoXmlTag("BlgStart")]
    public IsoISODate? BillingStart { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blen")]
    [DisplayName("Billing End")]
    [IsoXmlTag("BlgEnd")]
    public IsoISODate? BillingEnd { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-blev")]
    [DisplayName("Billing Event")]
    [IsoXmlTag("BlgEvt")]
    public ValueList<TelecomBillingEventAmount1> BillingEvent { get; init; } = [];

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ttlx")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax44> TotalTax { get; init; } = [];

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ttla")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-lnit")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<TelecomServicesLineItem4> LineItem { get; init; } = [];

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_mkgbEUhsEfCMZJtj4J7UGQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
