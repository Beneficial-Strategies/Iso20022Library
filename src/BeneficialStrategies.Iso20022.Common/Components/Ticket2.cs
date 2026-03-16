// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains ticket details.
/// </summary>
[IsoId("__KxJscWkEeuhguwJmlgagQ")]
[DisplayName("Ticket")]
public record Ticket2
{
    /// <summary>
    /// Contains the ticket number.
    /// </summary>
    [IsoId("__PZLAcWkEeuhguwJmlgagQ")]
    [DisplayName("Ticket Number")]
    [IsoXmlTag("TcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TicketNumber { get; init; }

    /// <summary>
    /// Name of the issuing ticket agent.
    /// </summary>
    [IsoId("__PZLA8WkEeuhguwJmlgagQ")]
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public PartyIdentification258? TicketIssuer { get; init; }

    /// <summary>
    /// Date the ticket was issued.
    /// </summary>
    [IsoId("__PZLBcWkEeuhguwJmlgagQ")]
    [DisplayName("Ticket Issue Date")]
    [IsoXmlTag("TcktIsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TicketIssueDate { get; init; }

    /// <summary>
    /// Location where ticket was issued.
    /// </summary>
    [IsoId("__PZLB8WkEeuhguwJmlgagQ")]
    [DisplayName("Ticket Issue Location")]
    [IsoXmlTag("TcktIsseLctn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TicketIssueLocation { get; init; }

    /// <summary>
    /// Number of a ticket that contains additional coupons for an itinerary that contains more than four segments.
    /// </summary>
    [IsoId("__PZLCcWkEeuhguwJmlgagQ")]
    [DisplayName("Conjunction Ticket Number")]
    [IsoXmlTag("CnjnctnTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ConjunctionTicketNumber { get; init; }

    /// <summary>
    /// Indicates whether or not restrictions apply to the ticket.
    /// True = Restrictions apply
    /// False = Restrictions do not apply
    /// </summary>
    [IsoId("__PZLC8WkEeuhguwJmlgagQ")]
    [DisplayName("Restricted Ticket Indicator")]
    [IsoXmlTag("RstrctdTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RestrictedTicketIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket is open-ended.
    /// True = Ticket is open-ended
    /// False = Ticket is not open-ended
    /// </summary>
    [IsoId("__PZLDcWkEeuhguwJmlgagQ")]
    [DisplayName("Open Ticket Indicator")]
    [IsoXmlTag("OpnTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OpenTicketIndicator { get; init; }

    /// <summary>
    /// Contains the specific restriction applicable to the ticket.
    /// </summary>
    [IsoId("__PZyEcWkEeuhguwJmlgagQ")]
    [DisplayName("Restrictions")]
    [IsoXmlTag("Rstrctns")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Restrictions { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket was exchanged (reissued or new ticket generated).
    /// True = Ticket was exchanged
    /// False = Ticket was not exchanged
    /// </summary>
    [IsoId("__PZyE8WkEeuhguwJmlgagQ")]
    [DisplayName("Exchanged Ticket Indicator")]
    [IsoXmlTag("XchgdTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExchangedTicketIndicator { get; init; }

    /// <summary>
    /// Contains the original ticket number that was replaced by the new ticket number.
    /// </summary>
    [IsoId("__PZyFcWkEeuhguwJmlgagQ")]
    [DisplayName("Exchanged Ticket Number")]
    [IsoXmlTag("XchgdTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExchangedTicketNumber { get; init; }

    /// <summary>
    /// Ticket record locator number.
    /// </summary>
    [IsoId("__PZyF8WkEeuhguwJmlgagQ")]
    [DisplayName("Record Locator Number")]
    [IsoXmlTag("RcrdLctrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecordLocatorNumber { get; init; }

    /// <summary>
    /// Reservation number or identifier.
    /// </summary>
    [IsoId("__PZyGcWkEeuhguwJmlgagQ")]
    [DisplayName("Reservation")]
    [IsoXmlTag("Rsvatn")]
    public ReservationDetails3? Reservation { get; init; }
}
