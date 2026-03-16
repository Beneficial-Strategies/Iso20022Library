// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_vTV8wZTIEemqYPWMBuVawg")]
[DisplayName("Investment Account")]
public record InvestmentAccount76
{
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_voK9RZTIEemqYPWMBuVawg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_voK9R5TIEemqYPWMBuVawg")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    [IsoId("_voK9SZTIEemqYPWMBuVawg")]
    [DisplayName("Fund Type")]
    [IsoXmlTag("FndTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FundType { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_voK9S5TIEemqYPWMBuVawg")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_voK9TZTIEemqYPWMBuVawg")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public FinancialInstrument55? SecurityDetails { get; init; }

    /// <summary>
    /// Owner of the account.
    /// </summary>
    [IsoId("_voK9T5TIEemqYPWMBuVawg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public AccountOwner3Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_voK9UZTIEemqYPWMBuVawg")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public Intermediary47? Intermediary { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_voK9U5TIEemqYPWMBuVawg")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification125Choice_? AccountServicer { get; init; }
}
