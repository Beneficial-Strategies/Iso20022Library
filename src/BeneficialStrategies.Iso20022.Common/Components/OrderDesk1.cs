// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an order desk.
/// </summary>
[IsoId("_yxKW8F9HEeicg40_9gK9vQ")]
[DisplayName("Order Desk")]
public record OrderDesk1
{
    /// <summary>
    /// Contact information for the order desk.
    /// </summary>
    [IsoId("_-OUWwV9HEeicg40_9gK9vQ")]
    [DisplayName("Order Desk")]
    [IsoXmlTag("OrdrDsk")]
    public ContactAttributes5? OrderDesk { get; init; }

    /// <summary>
    /// Days on which the order desk is closed.
    /// </summary>
    [IsoId("_WyRNsF9IEeicg40_9gK9vQ")]
    [DisplayName("Closure Dates")]
    [IsoXmlTag("ClsrDts")]
    public SimpleValueList<IsoISODate> ClosureDates { get; init; } = [];

    /// <summary>
    /// Additional information about the main order desk.
    /// </summary>
    [IsoId("_6umMIbAbEeiADpd1Q5gEyQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
