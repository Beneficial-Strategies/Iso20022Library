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
/// Content of the batch response message.
/// </summary>
[IsoId("_cr7GgXINEe2OqYulmHWukQ")]
[DisplayName("Batch Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BatchResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the bacth in an unambiguous way.
    /// </summary>
    [IsoId("_cz_dYXINEe2OqYulmHWukQ")]
    [DisplayName("Sale Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleBtchId")]
    #endif
    [IsoXmlTag("SaleBtchId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleBatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// POI identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_cz_dY3INEe2OqYulmHWukQ")]
    [DisplayName("POI Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIBtchId")]
    #endif
    [IsoXmlTag("POIBtchId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? POIBatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? POIBatchIdentification { get; init; } 
    #else
    public TransactionIdentifier1? POIBatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_cz_dZXINEe2OqYulmHWukQ")]
    [DisplayName("Performed Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfrmdTx")]
    #endif
    [IsoXmlTag("PrfrmdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PerformedTransaction5? PerformedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PerformedTransaction5? PerformedTransaction { get; init; } 
    #else
    public PerformedTransaction5? PerformedTransaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
