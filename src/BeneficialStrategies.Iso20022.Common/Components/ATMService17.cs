// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Services allowed for the customer&apos;s profile.
/// </summary>
[IsoId("_W5fkMa4XEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
public record ATMService17
{
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_XFtbQa4XEeW_TaP-ygI0SQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType8Code ServiceType { get; init; }

    /// <summary>
    /// Variant of the service.
    /// </summary>
    [IsoId("_Y-HR4K4YEeW_TaP-ygI0SQ")]
    [DisplayName("Service Variant")]
    [IsoXmlTag("SvcVarnt")]
    public ValueList<ATMService18> ServiceVariant { get; init; } = [];

    /// <summary>
    /// Limits of amounts.
    /// </summary>
    [IsoId("_XFtbQ64XEeW_TaP-ygI0SQ")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ValueList<ATMTransactionAmounts6> Limits { get; init; } = [];

    /// <summary>
    /// Preferred withdrawal transaction chosen by the customer.
    /// </summary>
    [IsoId("_XFtbRa4XEeW_TaP-ygI0SQ")]
    [DisplayName("Preferred Withdrawal")]
    [IsoXmlTag("PrefrdWdrwl")]
    public ATMTransaction8? PreferredWithdrawal { get; init; }
}
