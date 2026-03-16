// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides shareholdings information at account sub level.
/// </summary>
[IsoId("_4i27UDqqEemL_ewJY9QP1g")]
[DisplayName("Account Sub Level")]
public record AccountSubLevel20
{
    /// <summary>
    /// Account where financial instruments are maintained. Account serviced by the responding intermediary for an account holder.
    /// </summary>
    [IsoId("_ITuMBTqrEemL_ewJY9QP1g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ITuMBjqrEemL_ewJY9QP1g")]
    [DisplayName("Account Holder")]
    [IsoXmlTag("AcctHldr")]
    public required PartyIdentification196Choice_ AccountHolder { get; init; }

    /// <summary>
    /// Detailed shareholding balance information for an account.
    /// </summary>
    [IsoId("_kwbvEDttEemIf7eyjCwinw")]
    [DisplayName("Shareholding Balance")]
    [IsoXmlTag("ShrhldgBal")]
    public ValueList<ShareholdingBalance1> ShareholdingBalance { get; init; } = [];
    // ID for the above is _kwbvEDttEemIf7eyjCwinw
}
