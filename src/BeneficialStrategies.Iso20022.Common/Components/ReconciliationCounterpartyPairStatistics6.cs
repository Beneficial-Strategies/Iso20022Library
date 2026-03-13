// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on derivatives submitted for reconciliation per counterparty pair.
/// </summary>
[IsoId("_cHKG8VovEe23K4GXSpBSeg")]
[DisplayName("Reconciliation Counterparty Pair Statistics")]
public partial record ReconciliationCounterpartyPairStatistics6
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_cIzswVovEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData91 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Number of all reports per status on derivatives submitted for reconciliation per counterparty pair.
    /// </summary>
    [IsoId("_cIzsw1ovEe23K4GXSpBSeg")]
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    [IsoId("_cIzsxVovEe23K4GXSpBSeg")]
    [DisplayName("Reconciliation Report")]
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport14> ReconciliationReport { get; init; } = [];
    // ID for the above is _cIzsxVovEe23K4GXSpBSeg
    
    
    #nullable disable
    
}
