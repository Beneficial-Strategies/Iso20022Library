// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_AQe65TqWEemL_ewJY9QP1g")]
[DisplayName("Party Identification")]
public record PartyIdentification214
{
    /// <summary>
    /// Identification of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_LVUjYFSXEempisJfoIfvvQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification203Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_rh-REFSXEempisJfoIfvvQ")]
    [DisplayName("Recipient Name")]
    [IsoXmlTag("RcptNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text RecipientName { get; init; }

    /// <summary>
    /// Address of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_Evtr4FSYEempisJfoIfvvQ")]
    [DisplayName("Response Recipient Address")]
    [IsoXmlTag("RspnRcptAdr")]
    public required PartyAddress1 ResponseRecipientAddress { get; init; }
}
