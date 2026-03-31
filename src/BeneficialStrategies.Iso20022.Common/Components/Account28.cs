// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_IUwwcaVTEeiYMvosZPzV4g")]
[DisplayName("Account")]
public record Account28
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_bnJAEaVTEeiYMvosZPzV4g")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public PartyIdentification132? OwnerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ImnVc6VTEeiYMvosZPzV4g")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_ImnVdaVTEeiYMvosZPzV4g")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_ImnVd6VTEeiYMvosZPzV4g")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_ImnVeaVTEeiYMvosZPzV4g")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification132? Servicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_uXcokanhEeitU9ya4obnlw")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }
}
