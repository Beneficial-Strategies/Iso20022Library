// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch Response6.
/// </summary>
[IsoId("_5m3eIZTcEe6sd81HehWb6w")]
[DisplayName("Batch Response6")]
public partial record BatchResponse6
{
    #nullable enable

    /// <summary>
    /// Performed Transaction.
    /// </summary>
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public ValueList<PerformedTransaction6> PerformedTransaction { get; init; } = [];

    /// <summary>
    /// POI Batch Identification.
    /// </summary>
    [DisplayName("POI Batch Identification")]
    [IsoXmlTag("POIBtchId")]
    public TransactionIdentifier1? POIBatchIdentification { get; init; } 

    /// <summary>
    /// Sale Batch Identification.
    /// </summary>
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 

    
    #nullable disable
    
}
