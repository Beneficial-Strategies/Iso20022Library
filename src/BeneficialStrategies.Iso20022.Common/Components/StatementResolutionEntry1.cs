// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the statement entry for the resolution of the investigation.
/// </summary>
[IsoId("_T854ctp-Ed-ak6NoX_4Aeg_-1096123728")]
[DisplayName("Statement Resolution Entry")]
public partial record StatementResolutionEntry1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_T854c9p-Ed-ak6NoX_4Aeg_-277223583")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_T854dNp-Ed-ak6NoX_4Aeg_280847062")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the entry.
    /// </summary>
    [IsoId("_T854ddp-Ed-ak6NoX_4Aeg_83871841")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; } 
    
    /// <summary>
    /// Corrected debit or credit amount, compared to the original entry where the amount is incorrect.||Usage: This amount may only be present if an incorrect statement entry has been reported.
    /// </summary>
    [IsoId("_T854dtp-Ed-ak6NoX_4Aeg_-1523127340")]
    [DisplayName("Corrected Amount")]
    [IsoXmlTag("CrrctdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 
    
    /// <summary>
    /// Provides information on the charges included in the original entry amount.
    /// </summary>
    [IsoId("_T854d9p-Ed-ak6NoX_4Aeg_-1096122317")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesInformation6? Charges { get; init; } 
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_T854eNp-Ed-ak6NoX_4Aeg_-1096122864")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; } 
    
    
    #nullable disable
    
}
