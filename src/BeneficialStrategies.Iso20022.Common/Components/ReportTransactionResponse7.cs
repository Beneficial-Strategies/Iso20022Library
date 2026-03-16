// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Transaction Response7.
/// </summary>
[IsoId("_F1pa4aE5Ee-MRKYsaX6JDg")]
[DisplayName("Report Transaction Response7")]
public partial record ReportTransactionResponse7
{
    #nullable enable

    /// <summary>
    /// Block Start.
    /// </summary>
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    public required IsoPositiveNumber BlockStart { get; init; } 

    /// <summary>
    /// Block Stop.
    /// </summary>
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    public required IsoPositiveNumber BlockStop { get; init; } 

    /// <summary>
    /// Report Full Size.
    /// </summary>
    [DisplayName("Report Full Size")]
    [IsoXmlTag("RptFullSz")]
    public required IsoPositiveNumber ReportFullSize { get; init; } 

    /// <summary>
    /// Transaction Report.
    /// </summary>
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<ServiceResponse9> TransactionReport { get; init; } = [];

    
    #nullable disable
    
}
