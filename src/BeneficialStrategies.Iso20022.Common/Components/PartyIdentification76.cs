// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_i3sL4PPYEeS_qLctCs2aRQ")]
[DisplayName("Party Identification")]
public record PartyIdentification76
{
    /// <summary>
    /// Identifies the owner of the investment account which is used to acquire or sell financial instruments.
    /// </summary>
    [IsoId("_qNqT4PPYEeS_qLctCs2aRQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PersonOrOrganisation1Choice_ Identification { get; init; }

    /// <summary>
    /// Country of the branch that received the order from the client or made an investment decision for a client in accordance with a discretionary mandate given to it by the client.
    /// </summary>
    [IsoId("_WCovkfPZEeS_qLctCs2aRQ")]
    [DisplayName("Country Of Branch")]
    [IsoXmlTag("CtryOfBrnch")]
    public CountryCode? CountryOfBranch { get; init; }
}
