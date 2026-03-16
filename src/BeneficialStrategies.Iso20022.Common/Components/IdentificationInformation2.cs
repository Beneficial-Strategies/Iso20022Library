// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification information.
/// </summary>
[IsoId("_tpQTY1kyEeGeoaLUQk__nA_1045933986")]
[DisplayName("Identification Information")]
public record IdentificationInformation2
{
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    [IsoId("_tpQTZFkyEeGeoaLUQk__nA_-243096105")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification43? Party { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    [IsoId("_tpZdUFkyEeGeoaLUQk__nA_920996143")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public AccountIdentification4Choice_? Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    [IsoId("_tpZdUVkyEeGeoaLUQk__nA_-1232417062")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; }
}
