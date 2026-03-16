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
[IsoId("_BPv8AR1DEey8XKHwKquEQw")]
[DisplayName("Telecom Services Line Item")]
public record TelecomServicesLineItem2
{
    /// <summary>
    /// Contains the start date and time of the phone call.
    /// </summary>
    [IsoId("_BVmFUR1DEey8XKHwKquEQw")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDateTime { get; init; }

    /// <summary>
    /// Describes the period (such as peak or off peak) of the phone call.
    /// </summary>
    [IsoId("_BVmFUx1DEey8XKHwKquEQw")]
    [DisplayName("Time Period")]
    [IsoXmlTag("TmPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TimePeriod { get; init; }

    /// <summary>
    /// Duration of phone call expressed in HHMMSS format.
    /// </summary>
    [IsoId("_BVmFVR1DEey8XKHwKquEQw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Duration { get; init; }

    /// <summary>
    /// Contains the location description for the originator of the telephone call and the number from which the call was made.
    /// </summary>
    [IsoId("_BVmFVx1DEey8XKHwKquEQw")]
    [DisplayName("Call From")]
    [IsoXmlTag("CallFr")]
    public TelecomCallDetails2? CallFrom { get; init; }

    /// <summary>
    /// Contains the location description for the destination of the telephone call and the number to which the call was made.
    /// </summary>
    [IsoId("_BVmFWR1DEey8XKHwKquEQw")]
    [DisplayName("Call To")]
    [IsoXmlTag("CallTo")]
    public TelecomCallDetails2? CallTo { get; init; }

    /// <summary>
    /// Contains the amount pertaining to the telephony billing event.
    /// </summary>
    [IsoId("_BVmFWx1DEey8XKHwKquEQw")]
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public Amount20? Charge { get; init; }

    /// <summary>
    /// Total of taxes applicable to the billing amount
    /// </summary>
    [IsoId("_BVmFXR1DEey8XKHwKquEQw")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public Tax39? TotalTax { get; init; }

    /// <summary>
    /// Total amount applicable to the billing event.
    /// </summary>
    [IsoId("_BVmFXx1DEey8XKHwKquEQw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Description of the telecommunications services line item details
    /// </summary>
    [IsoId("_BVmFYR1DEey8XKHwKquEQw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the telecommunications services.
    /// </summary>
    [IsoId("_BVmFYx1DEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
