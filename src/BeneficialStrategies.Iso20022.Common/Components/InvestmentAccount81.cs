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
[IsoId("838fcf21-82d1-4ad8-acbf-b002be6fc68f")]
[DisplayName("Investment Account81")]
public record InvestmentAccount81
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("9a98d03f-96b7-46c8-88c9-7ab7e6df012c")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("977f2f5b-5d03-429d-9b77-1eeaabb0ea89")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("7c58bb59-d90a-4935-8f61-cc3dc5fd6601")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("475598a5-be97-42c0-91c1-e9f12aef33eb")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification139> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Party that manages the account on behalf of the account owner.
    /// </summary>
    [IsoId("9eea1cc6-8b4f-4205-be67-12048d71b41b")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("ac9b6351-bf29-4395-a969-99cd3c37cdb4")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("e81d9a7c-78a3-479e-a3ec-5aa31cb37f93")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount6? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("96b3fd1c-b41c-4cb3-ac3d-4d57ee689a73")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
