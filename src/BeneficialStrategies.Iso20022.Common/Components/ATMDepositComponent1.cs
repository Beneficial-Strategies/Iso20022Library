// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Deposit Component1.
/// </summary>
[IsoId("_y8Q3kJ2qEe-4seDr3Li2Ew")]
[DisplayName("ATM Deposit Component1")]
public record ATMDepositComponent1
{
    /// <summary>
    /// Account Data.
    /// </summary>
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public ValueList<CardAccount21> AccountData { get; init; } = [];

    /// <summary>
    /// Deposited Media.
    /// </summary>
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ValueList<ATMDepositedMedia4> DepositedMedia { get; init; } = [];

    /// <summary>
    /// Detailed Requested Amount.
    /// </summary>
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public ValueList<DetailedAmount16> DetailedRequestedAmount { get; init; } = [];

    /// <summary>
    /// Protected Account Data.
    /// </summary>
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ValueList<ContentInformationType10> ProtectedAccountData { get; init; } = [];

    /// <summary>
    /// Sub Deposit Identification.
    /// </summary>
    [DisplayName("Sub Deposit Identification")]
    [IsoXmlTag("SubDpstId")]
    public IsoMax70Text? SubDepositIdentification { get; init; }
}
