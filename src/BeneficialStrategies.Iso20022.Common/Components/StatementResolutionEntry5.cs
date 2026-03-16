// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement Resolution Entry5.
/// </summary>
[IsoId("_xtnDcTEyEe6g-ffJsqGiSA")]
[DisplayName("Statement Resolution Entry5")]
public partial record StatementResolutionEntry5
{
    #nullable enable

    /// <summary>
    /// Account Servicer Reference.
    /// </summary>
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; } 

    /// <summary>
    /// Charges.
    /// </summary>
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<Charges15> Charges { get; init; } = [];

    /// <summary>
    /// Corrected Amount.
    /// </summary>
    [DisplayName("Corrected Amount")]
    [IsoXmlTag("CrrctdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CorrectedAmount { get; init; } 

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 

    /// <summary>
    /// Original Statement Identification.
    /// </summary>
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; } 

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; } 

    
    #nullable disable
    
}
