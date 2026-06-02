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
[IsoId("21c05e31-d061-4a92-a3f2-6fdd9b1ae543")]
[DisplayName("Account38")]
public record Account38
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("49f559a0-3e04-413c-8c33-979cce41baa5")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("f04bd16d-bf1a-44b6-b44f-2b927432607a")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("3d0965a4-fc30-48f9-8998-8d762453e6a8")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("b51287d0-b69c-4166-9ace-079f5624d922")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification139? Servicer { get; init; }

    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("29eb90ae-28fe-4539-bec3-30343aeeaf05")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("b94ec393-9983-4676-9c61-dacf357da7d7")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
