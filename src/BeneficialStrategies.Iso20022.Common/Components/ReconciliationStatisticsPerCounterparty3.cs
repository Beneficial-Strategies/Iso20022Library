// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on derivatives submitted for reconciliation.
/// </summary>
[IsoId("_cFhvQVovEe23K4GXSpBSeg")]
[DisplayName("Reconciliation Statistics Per Counterparty")]
public partial record ReconciliationStatisticsPerCounterparty3
{
    #nullable enable
    
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_cHFOcVovEe23K4GXSpBSeg")]
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReferenceDate { get; init; } 
    
    /// <summary>
    /// Different categories of statuses for a derivative.
    /// </summary>
    [IsoId("_cHFOc1ovEe23K4GXSpBSeg")]
    [DisplayName("Reconciliation Categories")]
    [IsoXmlTag("RcncltnCtgrs")]
    public required ReportingRequirement2Choice_ ReconciliationCategories { get; init; } 
    
    /// <summary>
    /// Number of all reports per status on derivatives submitted for reconciliation.
    /// </summary>
    [IsoId("_cHFOdVovEe23K4GXSpBSeg")]
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Details of derivatives submitted for reconciliation per counterparty pair.
    /// </summary>
    [IsoId("_cHFOd1ovEe23K4GXSpBSeg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ReconciliationCounterpartyPairStatistics6? TransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
