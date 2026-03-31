// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_-wFGsXdhEeuvip1zrZRWzw")]
[DisplayName("Intermediary")]
public record Intermediary48
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary or a party related to the transfer.
    /// </summary>
    [IsoId("__CFcs3dhEeuvip1zrZRWzw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification132 Identification { get; init; }

    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("__CFctXdhEeuvip1zrZRWzw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account34? Account { get; init; }

    /// <summary>
    /// Function performed by the intermediary or related party.
    /// </summary>
    [IsoId("__CFct3dhEeuvip1zrZRWzw")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role8Choice_? Role { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("__CFcuXdhEeuvip1zrZRWzw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
