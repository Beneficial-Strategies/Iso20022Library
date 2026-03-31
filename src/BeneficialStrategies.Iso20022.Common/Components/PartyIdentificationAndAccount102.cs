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
[IsoId("_6HoQkWpMEeSjPYeXoHq7Ng")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount102
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_6jTf82pMEeSjPYeXoHq7Ng")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification33Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_6jTf9WpMEeSjPYeXoHq7Ng")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [IsoId("_6jTf92pMEeSjPYeXoHq7Ng")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [IsoId("_6jTf-WpMEeSjPYeXoHq7Ng")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_6jTf-2pMEeSjPYeXoHq7Ng")]
    [DisplayName("Sub Account")]
    [IsoXmlTag("SubAcct")]
    public SubAccount4? SubAccount { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_6jTf_WpMEeSjPYeXoHq7Ng")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
