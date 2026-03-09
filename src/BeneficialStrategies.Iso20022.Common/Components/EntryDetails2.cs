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
/// Identifies the underlying transaction(s) and/or batched entries.
/// </summary>
[IsoId("_tt3tpFkyEeGeoaLUQk__nA_1866837598")]
[DisplayName("Entry Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntryDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("_tuBeoFkyEeGeoaLUQk__nA_1516691332")]
    [DisplayName("Batch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Btch")]
    #endif
    [IsoXmlTag("Btch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchInformation2? Batch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchInformation2? Batch { get; init; } 
    #else
    public BatchInformation2? Batch { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("_tuBeoVkyEeGeoaLUQk__nA_-1140191613")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EntryTransaction3? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryTransaction3? TransactionDetails { get; init; } 
    #else
    public EntryTransaction3? TransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
