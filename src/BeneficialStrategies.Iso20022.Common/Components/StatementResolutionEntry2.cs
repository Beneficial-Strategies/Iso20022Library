// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the statement entry for the resolution of the investigation.
/// </summary>
[IsoId("_ttIGwFkyEeGeoaLUQk__nA_2058261380")]
[DisplayName("Statement Resolution Entry")]
public record StatementResolutionEntry2
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_ttIGwVkyEeGeoaLUQk__nA_-1850669866")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_ttIGwlkyEeGeoaLUQk__nA_1775619466")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    [IsoId("_ttIGw1kyEeGeoaLUQk__nA_-708512893")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    [IsoId("_ttIGxFkyEeGeoaLUQk__nA_52252260")]
    [DisplayName("Corrected Amount")]
    [IsoXmlTag("CrrctdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; }

    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    [IsoId("_ttR3wFkyEeGeoaLUQk__nA_-1665746860")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<Charges3> Charges { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_ttR3wVkyEeGeoaLUQk__nA_-1193638900")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
