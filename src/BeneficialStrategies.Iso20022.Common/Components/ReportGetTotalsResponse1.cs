// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Get Totals Response message.
/// </summary>
[IsoId("_k6DnIN6REeiwsev40qZGEQ")]
[DisplayName("Report Get Totals Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportGetTotalsResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportGetTotalsResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportGetTotalsResponse1( System.String reqPOIReconciliationIdentification )
    {
        POIReconciliationIdentification = reqPOIReconciliationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [IsoId("_t9D4sN6REeiwsev40qZGEQ")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text POIReconciliationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String POIReconciliationIdentification { get; init; } 
    #else
    public System.String POIReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the Sale to POI Totals processing.
    /// </summary>
    [IsoId("_wvXBMN6REeiwsev40qZGEQ")]
    [DisplayName("Transaction Totals Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtlsSet")]
    #endif
    [IsoXmlTag("TxTtlsSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionTotalsSet1? TransactionTotalsSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotalsSet1? TransactionTotalsSet { get; init; } 
    #else
    public TransactionTotalsSet1? TransactionTotalsSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
