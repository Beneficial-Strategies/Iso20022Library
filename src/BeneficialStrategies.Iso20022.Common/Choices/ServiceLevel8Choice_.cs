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
    [KnownType(typeof(ServiceLevel8Choice.Code))]
    [KnownType(typeof(ServiceLevel8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ServiceLevel8Choice.Code),nameof(ServiceLevel8Choice.Code))]
    [JsonDerivedType(typeof(ServiceLevel8Choice.Proprietary),nameof(ServiceLevel8Choice.Proprietary))]
    #endif
    [IsoId("_QJa_zNp-Ed-ak6NoX_4Aeg_1912716963")]
    [DisplayName("Service Level 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ServiceLevel8Choice_
    #else
    public abstract partial class ServiceLevel8Choice_
    #endif
    {
    }
}
