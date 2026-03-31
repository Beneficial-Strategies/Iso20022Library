// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of check as payment instrument.
/// </summary>
[IsoId("_grZ50NkJEeiojJsa6FYyew")]
[DisplayName("Check")]
public record Check1
{
    /// <summary>
    /// Identification of the institution (bank) issuing the check.
    /// </summary>
    [IsoId("_wrMXUNkJEeiojJsa6FYyew")]
    [DisplayName("Bank Identification")]
    [IsoXmlTag("BkId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BankIdentification { get; init; }

    /// <summary>
    /// Identification of the account linked to the check.
    /// </summary>
    [IsoId("_qyELUNkKEeiojJsa6FYyew")]
    [DisplayName("Account Number")]
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountNumber { get; init; }

    /// <summary>
    /// Identification of the check.
    /// </summary>
    [IsoId("_0LCs4NkKEeiojJsa6FYyew")]
    [DisplayName("Check Number")]
    [IsoXmlTag("ChckNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CheckNumber { get; init; }

    /// <summary>
    /// Check guarantee card number.
    /// The human readable number from the Check Guarantee Card that is presented during the check tendering process.
    /// </summary>
    [IsoId("_Aq0nUNkLEeiojJsa6FYyew")]
    [DisplayName("Check Card Number")]
    [IsoXmlTag("ChckCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CheckCardNumber { get; init; }

    /// <summary>
    /// Track Data of the check to digitally identify the data.
    /// </summary>
    [IsoId("_AS8dYNkMEeiojJsa6FYyew")]
    [DisplayName("Check Track Data")]
    [IsoXmlTag("ChckTrckData2")]
    public TrackData2? CheckTrackData2 { get; init; }

    /// <summary>
    /// Type of the check (personal or professional).
    /// </summary>
    [IsoId("_DJ9mQNtbEeipuvJHTHIw9A")]
    [DisplayName("Check Type")]
    [IsoXmlTag("ChckTp")]
    public CheckType1Code? CheckType { get; init; }

    /// <summary>
    /// Country of the check.
    /// </summary>
    [IsoId("_H-b-4NkLEeiojJsa6FYyew")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? Country { get; init; }
}
