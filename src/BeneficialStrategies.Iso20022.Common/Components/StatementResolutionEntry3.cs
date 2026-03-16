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
[IsoId("_b3LNkdwYEee0mvR9H3APRg")]
[DisplayName("Statement Resolution Entry")]
public record StatementResolutionEntry3
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_cHruw9wYEee0mvR9H3APRg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_cHruxdwYEee0mvR9H3APRg")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    [IsoId("_cHrux9wYEee0mvR9H3APRg")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    [IsoId("_cHruydwYEee0mvR9H3APRg")]
    [DisplayName("Corrected Amount")]
    [IsoXmlTag("CrrctdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; }

    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    [IsoId("_cHruy9wYEee0mvR9H3APRg")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<Charges3> Charges { get; init; } = [];

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_cHruzdwYEee0mvR9H3APRg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
