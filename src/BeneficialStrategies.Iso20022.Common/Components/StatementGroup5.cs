// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement Group5.
/// </summary>
[IsoId("_xZNgwTEyEe6g-ffJsqGiSA")]
[DisplayName("Statement Group5")]
public record StatementGroup5
{
    /// <summary>
    /// Billing Statement.
    /// </summary>
    [DisplayName("Billing Statement")]
    [IsoXmlTag("BllgStmt")]
    public ValueList<BillingStatement5> BillingStatement { get; init; } = [];

    /// <summary>
    /// Group Identification.
    /// </summary>
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    public required IsoMax35Text GroupIdentification { get; init; }

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public required PartyIdentification273 Receiver { get; init; }

    /// <summary>
    /// Receiver Individual Contact.
    /// </summary>
    [DisplayName("Receiver Individual Contact")]
    [IsoXmlTag("RcvrIndvCtct")]
    public Contact13? ReceiverIndividualContact { get; init; }

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public required PartyIdentification273 Sender { get; init; }

    /// <summary>
    /// Sender Individual Contact.
    /// </summary>
    [DisplayName("Sender Individual Contact")]
    [IsoXmlTag("SndrIndvCtct")]
    public Contact13? SenderIndividualContact { get; init; }
}
