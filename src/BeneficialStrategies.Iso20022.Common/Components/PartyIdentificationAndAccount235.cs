// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[IsoId("eb052e1b-9147-4369-9e5b-db9ca9c43a17")]
[DisplayName("Party Identification And Account235")]
public record PartyIdentificationAndAccount235
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("146cd1ee-578d-4b44-8eee-fddad8e4447a")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification139 PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("f103f41e-8ad2-4baa-8b13-7e3be5e5f451")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("9188694e-0bc8-4c2d-8b2c-5f040d705781")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
