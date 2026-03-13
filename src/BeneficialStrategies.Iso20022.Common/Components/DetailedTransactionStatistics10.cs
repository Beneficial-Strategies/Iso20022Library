// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
[IsoId("_j31tca4cEemB_csI4yyKLA")]
[DisplayName("Detailed Transaction Statistics")]
public partial record DetailedTransactionStatistics10
{
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_j8wpsa4cEemB_csI4yyKLA")]
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    [IsoId("_j8wps64cEemB_csI4yyKLA")]
    [DisplayName("Total Number Of Transactions Accepted")]
    [IsoXmlTag("TtlNbOfTxsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; } 
    
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    [IsoId("_j8wpta4cEemB_csI4yyKLA")]
    [DisplayName("Total Number Of Transactions Rejected")]
    [IsoXmlTag("TtlNbOfTxsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; } 
    
    /// <summary>
    /// Number of transactions rejected per error code.
    /// </summary>
    [IsoId("_j8wpt64cEemB_csI4yyKLA")]
    [DisplayName("Number Of Transactions Rejected")]
    [IsoXmlTag("NbOfTxsRjctd")]
    public ValueList<RejectionReason47> NumberOfTransactionsRejected { get; init; } = [];
    // ID for the above is _j8wpt64cEemB_csI4yyKLA
    
    
    #nullable disable
    
}
