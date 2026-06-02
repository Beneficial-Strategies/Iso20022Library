// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund.
/// </summary>
[IsoId("49efc15a-fa90-434d-989a-1990d6bc3077")]
[DisplayName("Account36")]
public record Account36
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("24b695a8-df12-427e-adae-ae91337c6782")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public PartyIdentification132? OwnerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("8a170b65-f7dd-45db-a14e-30ee9905f64d")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("2fb556b4-281b-4625-b58f-de8ee90311c1")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("dbdfa2bd-9e0c-489d-8745-0378f06303b9")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("95ec0de8-9b0a-4f1a-809f-ea8bb92a1066")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification30? Type { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("57252dde-3903-4a2d-a2d9-8bbae825eea9")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification132? Servicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("ca721f4f-42e3-4f4b-9efe-e71287755d14")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("aca7fea5-3650-4914-9834-779552b8a6eb")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
