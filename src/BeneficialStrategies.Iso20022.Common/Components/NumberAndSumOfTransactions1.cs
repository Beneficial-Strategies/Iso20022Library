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
/// Set of elements providing the total sum of entries.
/// </summary>
[IsoId("_RU-M4Np-Ed-ak6NoX_4Aeg_1799173241")]
[DisplayName("Number And Sum Of Transactions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberAndSumOfTransactions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M4dp-Ed-ak6NoX_4Aeg_-2019260221")]
    [DisplayName("Number Of Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfNtries")]
    #endif
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfEntries { get; init; } 
    #else
    public System.String? NumberOfEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M4tp-Ed-ak6NoX_4Aeg_-2019260161")]
    [DisplayName("Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sum")]
    #endif
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Sum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Sum { get; init; } 
    #else
    public System.UInt64? Sum { get; set; } 
    #endif
    
    
    #nullable disable
    
}
