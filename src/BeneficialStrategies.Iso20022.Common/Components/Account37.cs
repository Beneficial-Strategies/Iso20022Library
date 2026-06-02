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
[IsoId("12ebde8c-20bc-4456-bbfb-a46afe86f4a8")]
[DisplayName("Account37")]
public record Account37
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("78561c61-17fa-497a-8236-61a814ec8b06")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public PartyIdentification132? OwnerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("fe6bbf8c-09dd-4e77-a9a9-6cecf9159d09")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("5d76cc9f-e470-4b0b-93ce-c0ce5de05424")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("145017cb-aa4b-42e7-9826-8a057937a1c3")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("90834c82-dde6-425d-8f01-18579ecce5fe")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification132? Servicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("d4bdb661-5d28-439e-91c7-497cdfa159f0")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("6018f149-4fc6-477e-a37c-33dd45e698f5")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
