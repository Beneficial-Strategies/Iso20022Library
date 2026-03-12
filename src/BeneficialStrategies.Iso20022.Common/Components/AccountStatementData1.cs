// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
[IsoId("_HJDAdPGgEeiGNursv3uE_g")]
[DisplayName("Account Statement Data")]
public partial record AccountStatementData1
{
    #nullable enable
    
    /// <summary>
    /// Date the statement is generated.
    /// </summary>
    [IsoId("_HJDAdfGgEeiGNursv3uE_g")]
    [DisplayName("Statement Date")]
    [IsoXmlTag("StmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StatementDate { get; init; } 
    
    /// <summary>
    /// Time the account statement is generated.
    /// </summary>
    [IsoId("_HJDngfGgEeiGNursv3uE_g")]
    [DisplayName("Statement Time")]
    [IsoXmlTag("StmtTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? StatementTime { get; init; } 
    
    /// <summary>
    /// Statement information.
    /// </summary>
    [IsoId("_HJDngPGgEeiGNursv3uE_g")]
    [DisplayName("Account Statement")]
    [IsoXmlTag("AcctStmt")]
    public AccountStatementDetails1? AccountStatement { get; init; } 
    
    
    #nullable disable
    
}
