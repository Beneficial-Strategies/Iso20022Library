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
[IsoId("_z8ujsTbsEead9bDRE_1DAQ")]
[DisplayName("Investment Account")]
public record InvestmentAccount58
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_0UrwtTbsEead9bDRE_1DAQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_0UrwtzbsEead9bDRE_1DAQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_0UrwuTbsEead9bDRE_1DAQ")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_0UrwuzbsEead9bDRE_1DAQ")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification113> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_0UrwvTbsEead9bDRE_1DAQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification113? AccountServicer { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_0UrwvzbsEead9bDRE_1DAQ")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_0UrwwTbsEead9bDRE_1DAQ")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount6? SubAccountDetails { get; init; }
}
