// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services line item carries detail level telephony billing data.
/// </summary>
[IsoId("_QFeoF_fDEei89sMSHxl1ew")]
[DisplayName("Telecom Services Line Item")]
public record TelecomServicesLineItem1
{
    /// <summary>
    /// Contains the start date and time of the phone call.
    /// </summary>
    [IsoId("_QFeoGPfDEei89sMSHxl1ew")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDateTime { get; init; }

    /// <summary>
    /// Describes the period (such as peak or off peak) of the phone call.
    /// </summary>
    [IsoId("_QFeoGvfDEei89sMSHxl1ew")]
    [DisplayName("Time Period")]
    [IsoXmlTag("TmPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TimePeriod { get; init; }

    /// <summary>
    /// Duration of phone call expressed in HHMMSS format.
    /// </summary>
    [IsoId("_usTK8ffEEei89sMSHxl1ew")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Duration { get; init; }

    /// <summary>
    /// Contains the location description for the originator of the telephone call and the number from which the call was made.
    /// </summary>
    [IsoId("_9brzsPfIEei89sMSHxl1ew")]
    [DisplayName("Call From")]
    [IsoXmlTag("CallFr")]
    public TelecomCallDetails1? CallFrom { get; init; }

    /// <summary>
    /// Contains the location description for the destination of the telephone call and the number to which the call was made.
    /// </summary>
    [IsoId("_WvEjgPfJEei89sMSHxl1ew")]
    [DisplayName("Call To")]
    [IsoXmlTag("CallTo")]
    public TelecomCallDetails1? CallTo { get; init; }

    /// <summary>
    /// Contains the amount pertaining to the telephony billing event.
    /// </summary>
    [IsoId("_QFeoHPfDEei89sMSHxl1ew")]
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public ValueList<Amount11> Charge { get; init; } = [];

    /// <summary>
    /// Total of taxes applicable to the billing amount
    /// </summary>
    [IsoId("_QFeoGffDEei89sMSHxl1ew")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax33> TotalTax { get; init; } = [];

    /// <summary>
    /// Total amount applicable to the billing event.
    /// </summary>
    [IsoId("_CngQ8PfMEei89sMSHxl1ew")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Description of the telecommunications services line item details
    /// </summary>
    [IsoId("_Jo-IkPfMEei89sMSHxl1ew")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the telecommunications services.
    /// </summary>
    [IsoId("_QFgdQPfDEei89sMSHxl1ew")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
