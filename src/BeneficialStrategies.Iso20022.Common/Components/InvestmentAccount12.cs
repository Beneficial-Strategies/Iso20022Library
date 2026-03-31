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
[IsoId("_U9ImZ9p-Ed-ak6NoX_4Aeg_198785493")]
[DisplayName("Investment Account")]
public record InvestmentAccount12
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_U9ImaNp-Ed-ak6NoX_4Aeg_1098293012")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_U9Imadp-Ed-ak6NoX_4Aeg_1098293097")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_U9RwUNp-Ed-ak6NoX_4Aeg_-1907652497")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_U9RwUdp-Ed-ak6NoX_4Aeg_-1906731920")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary1> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_U9RwUtp-Ed-ak6NoX_4Aeg_-566422199")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification1Choice_? AccountServicer { get; init; }
}
