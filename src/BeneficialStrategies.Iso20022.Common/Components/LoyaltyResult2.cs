// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// </summary>
[IsoId("_fk10wQ0zEeqUVL7sB4m7NA")]
[DisplayName("Loyalty Result")]
public record LoyaltyResult2
{
    /// <summary>
    /// Account managing the Loyalty.
    /// </summary>
    [IsoId("_fwrRUQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required LoyaltyAccount2 Account { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [IsoId("_fwrRUw0zEeqUVL7sB4m7NA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public LoyaltyAmount1? Amount { get; init; }

    /// <summary>
    /// Data sent by the Loyalty server.
    /// </summary>
    [IsoId("_fwrRVQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Server Data")]
    [IsoXmlTag("SvrData")]
    public LoyaltyServerData1? ServerData { get; init; }

    /// <summary>
    /// Rebate information.
    /// </summary>
    [IsoId("_fwrRVw0zEeqUVL7sB4m7NA")]
    [DisplayName("Rebates")]
    [IsoXmlTag("Rbts")]
    public LoyaltyRebates1? Rebates { get; init; }
}
