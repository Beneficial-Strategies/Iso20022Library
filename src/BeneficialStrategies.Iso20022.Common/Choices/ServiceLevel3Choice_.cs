// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the service level of the transaction.
    /// </summary>
    [KnownType(typeof(ServiceLevel3Choice.Code))]
    [KnownType(typeof(ServiceLevel3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ServiceLevel3Choice.Code),nameof(ServiceLevel3Choice.Code))]
    [JsonDerivedType(typeof(ServiceLevel3Choice.Proprietary),nameof(ServiceLevel3Choice.Proprietary))]
    #endif
    [IsoId("_QJkwxNp-Ed-ak6NoX_4Aeg_1187501352")]
    [DisplayName("Service Level 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ServiceLevel3Choice_
    #else
    public abstract partial class ServiceLevel3Choice_
    #endif
    {
    }
}
