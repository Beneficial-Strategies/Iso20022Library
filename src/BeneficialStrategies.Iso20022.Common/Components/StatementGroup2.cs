// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of the statement header reporting the bank services billing and the billing statement.
/// </summary>
[IsoId("_akFHMTq2EeWZFYSPlduMhw")]
[DisplayName("Statement Group")]
public record StatementGroup2
{
    /// <summary>
    /// Identification of a group of customer billing statements.
    /// </summary>
    [IsoId("_arIxcTq2EeWZFYSPlduMhw")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text GroupIdentification { get; init; }

    /// <summary>
    /// Originating financial institution sending the statement.
    /// </summary>
    [IsoId("_arIxczq2EeWZFYSPlduMhw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public required PartyIdentification58 Sender { get; init; }

    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the sender&apos;s location.
    /// </summary>
    [IsoId("_arIxdTq2EeWZFYSPlduMhw")]
    [DisplayName("Sender Individual Contact")]
    [IsoXmlTag("SndrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> SenderIndividualContact { get; init; } = [];

    /// <summary>
    /// Financial institution customer receiving the statement.
    /// </summary>
    [IsoId("_arIxdzq2EeWZFYSPlduMhw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public required PartyIdentification58 Receiver { get; init; }

    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the receiver&apos;s location.
    /// </summary>
    [IsoId("_arIxeTq2EeWZFYSPlduMhw")]
    [DisplayName("Receiver Individual Contact")]
    [IsoXmlTag("RcvrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> ReceiverIndividualContact { get; init; } = [];

    /// <summary>
    /// Provides the bank services billing statement recounting of all service chargeable events that occurred during a reporting cycle, such as the end of the month reporting.
    /// </summary>
    [IsoId("_arIxezq2EeWZFYSPlduMhw")]
    [DisplayName("Billing Statement")]
    [IsoXmlTag("BllgStmt")]
    public ValueList<BillingStatement2> BillingStatement { get; init; } = [];
    // ID for the above is _arIxezq2EeWZFYSPlduMhw
}
