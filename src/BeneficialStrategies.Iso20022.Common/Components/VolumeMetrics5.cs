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
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
[IsoId("_d5k5U65MEeuo-IflVgGqiA")]
[DisplayName("Volume Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeMetrics5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Count of the number of Unique Trade Identifiers. 
    /// </summary>
    [IsoId("_eIL9Ea5MEeuo-IflVgGqiA")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Sum for each exposure variable and currency.
    /// </summary>
    [IsoId("_eIL9E65MEeuo-IflVgGqiA")]
    [DisplayName("Exposure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xpsr")]
    #endif
    [IsoXmlTag("Xpsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureMetrics4? Exposure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureMetrics4? Exposure { get; init; } 
    #else
    public ExposureMetrics4? Exposure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
