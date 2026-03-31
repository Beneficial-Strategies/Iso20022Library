// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_jHbk4XzhEeuEHsEB8Johfw")]
[DisplayName("Account")]
public record Account34
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jeW3I3zhEeuEHsEB8Johfw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_sMUs0HzhEeuEHsEB8Johfw")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_sMUs0XzhEeuEHsEB8Johfw")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_jeW3JXzhEeuEHsEB8Johfw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification132 AccountServicer { get; init; }

    /// <summary>
    /// Address of the nominee company that holds the assets at the transfer agent or International Central Securities Depository or Central Securities Depository on behalf of the party.
    /// </summary>
    [IsoId("_5jdtEXzhEeuEHsEB8Johfw")]
    [DisplayName("Registration Address")]
    [IsoXmlTag("RegnAdr")]
    public PostalAddress1? RegistrationAddress { get; init; }
}
