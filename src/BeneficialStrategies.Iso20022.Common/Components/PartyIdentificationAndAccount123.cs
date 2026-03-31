// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
[IsoId("_JKHgoSSPEeWdoOFYMt-Lzw")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount123
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_JmiW4SSPEeWdoOFYMt-Lzw")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification70Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_JmiW4ySPEeWdoOFYMt-Lzw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [IsoId("_JmiW5SSPEeWdoOFYMt-Lzw")]
    [DisplayName("Processing Reference")]
    [IsoXmlTag("PrcgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingReference { get; init; }

    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [IsoId("_JmiW5ySPEeWdoOFYMt-Lzw")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_JmiW6SSPEeWdoOFYMt-Lzw")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_JmiW6ySPEeWdoOFYMt-Lzw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
