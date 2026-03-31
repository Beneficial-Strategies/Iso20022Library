// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom Services Line Item3.
/// </summary>
[IsoId("_h1mXQXTxEe6h-4AZRg9sVg")]
[DisplayName("Telecom Services Line Item3")]
public record TelecomServicesLineItem3
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Call From City.
    /// </summary>
    [DisplayName("Call From City")]
    [IsoXmlTag("CallFrCity")]
    public IsoMax35Text? CallFromCity { get; init; }

    /// <summary>
    /// Call From Country.
    /// </summary>
    [DisplayName("Call From Country")]
    [IsoXmlTag("CallFrCtry")]
    public ISOMax3ACountryCode? CallFromCountry { get; init; }

    /// <summary>
    /// Call From Country Sub Division Major.
    /// </summary>
    [DisplayName("Call From Country Sub Division Major")]
    [IsoXmlTag("CallFrCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CallFromCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Call From Country Sub Division Minor.
    /// </summary>
    [DisplayName("Call From Country Sub Division Minor")]
    [IsoXmlTag("CallFrCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CallFromCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Call From Other Type.
    /// </summary>
    [DisplayName("Call From Other Type")]
    [IsoXmlTag("CallFrOthrTp")]
    public IsoMax70Text? CallFromOtherType { get; init; }

    /// <summary>
    /// Call From Phone.
    /// </summary>
    [DisplayName("Call From Phone")]
    [IsoXmlTag("CallFrPhne")]
    public IsoPhoneNumber? CallFromPhone { get; init; }

    /// <summary>
    /// Call From Type.
    /// </summary>
    [DisplayName("Call From Type")]
    [IsoXmlTag("CallFrTp")]
    public TelephonyCallType1Code? CallFromType { get; init; }

    /// <summary>
    /// Call To City.
    /// </summary>
    [DisplayName("Call To City")]
    [IsoXmlTag("CallToCity")]
    public IsoMax35Text? CallToCity { get; init; }

    /// <summary>
    /// Call To Country.
    /// </summary>
    [DisplayName("Call To Country")]
    [IsoXmlTag("CallToCtry")]
    public ISOMax3ACountryCode? CallToCountry { get; init; }

    /// <summary>
    /// Call To Country Sub Division Major.
    /// </summary>
    [DisplayName("Call To Country Sub Division Major")]
    [IsoXmlTag("CallToCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CallToCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Call To Country Sub Division Minor.
    /// </summary>
    [DisplayName("Call To Country Sub Division Minor")]
    [IsoXmlTag("CallToCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CallToCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Call To Other Type.
    /// </summary>
    [DisplayName("Call To Other Type")]
    [IsoXmlTag("CallToOthrTp")]
    public IsoMax70Text? CallToOtherType { get; init; }

    /// <summary>
    /// Call To Phone.
    /// </summary>
    [DisplayName("Call To Phone")]
    [IsoXmlTag("CallToPhne")]
    public IsoPhoneNumber? CallToPhone { get; init; }

    /// <summary>
    /// Call To Type.
    /// </summary>
    [DisplayName("Call To Type")]
    [IsoXmlTag("CallToTp")]
    public TelephonyCallType1Code? CallToType { get; init; }

    /// <summary>
    /// Charge.
    /// </summary>
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public ValueList<Amount23> Charge { get; init; } = [];

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoISOTime? Duration { get; init; }

    /// <summary>
    /// Start Date Time.
    /// </summary>
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public IsoISODate? StartDateTime { get; init; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    /// <summary>
    /// Time Period.
    /// </summary>
    [DisplayName("Time Period")]
    [IsoXmlTag("TmPrd")]
    public IsoMax35Text? TimePeriod { get; init; }

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }
}
