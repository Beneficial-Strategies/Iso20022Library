// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details related to an individual trip.
/// </summary>
[IsoId("_X6Xf1_i3EeiJaN6-Lf-c_w")]
[DisplayName("Trip Information")]
public record TripInformation1
{
    /// <summary>
    /// Identification number of the trip.
    /// </summary>
    [IsoId("_X6YG4vi3EeiJaN6-Lf-c_w")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripNumber { get; init; }

    /// <summary>
    /// Contains an indicator identifying the job or task identifier of the individual.
    /// </summary>
    [IsoId("_X6YG5Pi3EeiJaN6-Lf-c_w")]
    [DisplayName("Job Number")]
    [IsoXmlTag("JobNb")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? JobNumber { get; init; }

    /// <summary>
    /// Contains the work order or purchase order number.
    /// </summary>
    [IsoId("_X6YG5fi3EeiJaN6-Lf-c_w")]
    [DisplayName("Work Order")]
    [IsoXmlTag("WorkOrdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? WorkOrder { get; init; }

    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_X6YG4fi3EeiJaN6-Lf-c_w")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Contains the billing identification number.
    /// </summary>
    [IsoId("_X6YG4Pi3EeiJaN6-Lf-c_w")]
    [DisplayName("Billing Identification")]
    [IsoXmlTag("BllgId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? BillingIdentification { get; init; }

    /// <summary>
    /// Identification number assigned by an agent.
    /// </summary>
    [IsoId("_X6YG4_i3EeiJaN6-Lf-c_w")]
    [DisplayName("Control Number")]
    [IsoXmlTag("CtrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ControlNumber { get; init; }

    /// <summary>
    /// Delivery Ticket Number for the trip information.
    /// </summary>
    [IsoId("_kjUdAPi6EeiJaN6-Lf-c_w")]
    [DisplayName("Delivery Ticket Number")]
    [IsoXmlTag("DlvryTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryTicketNumber { get; init; }
}
