// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital account where digital assets or digital tokens can be stored and where an entry is made.
/// </summary>
[IsoId("9c743842-bfb1-4163-bd81-2e5c6836b4d2")]
[DisplayName("Block Chain Address Wallet14")]
public record BlockChainAddressWallet14
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("958094cd-e882-4e77-9b78-371ed4fd5bab")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("1fa2eef6-fdda-4253-9222-0ab0e4c48a22")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification30? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("2747708a-65df-4e67-959a-20d305cae13c")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Place of safekeeping expressed with a Digital Ledger Identifier.
    /// </summary>
    [IsoId("c4edb6ce-049a-41da-8321-25f1b52b703b")]
    [DisplayName("Digital Ledger Identification")]
    [IsoXmlTag("DgtlLdgrId")]
    public required IsoDTI2024Identifier DigitalLedgerIdentification { get; init; }
}
