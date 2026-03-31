// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification Information5.
/// </summary>
[IsoId("_zMxJGTEyEe6g-ffJsqGiSA")]
[DisplayName("Identification Information5")]
public record IdentificationInformation5
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Agent.
    /// </summary>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification8? Agent { get; init; }

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification272? Party { get; init; }
}
