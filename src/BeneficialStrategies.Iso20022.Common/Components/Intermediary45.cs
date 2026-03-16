// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
[IsoId("_Z0x7H_fVEeiNZp_PtLohLw")]
[DisplayName("Intermediary")]
public record Intermediary45
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_Z0x7I_fVEeiNZp_PtLohLw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification157 Identification { get; init; }

    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_Z0x7JffVEeiNZp_PtLohLw")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role7Choice_? Role { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_Z0x7J_fVEeiNZp_PtLohLw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account30? Account { get; init; }
}
