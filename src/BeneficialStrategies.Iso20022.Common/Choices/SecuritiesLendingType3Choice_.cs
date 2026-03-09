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
    /// Classification of the type of security.
    /// </summary>
    [KnownType(typeof(SecuritiesLendingType3Choice.Code))]
    [KnownType(typeof(SecuritiesLendingType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesLendingType3Choice.Code),nameof(SecuritiesLendingType3Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesLendingType3Choice.Proprietary),nameof(SecuritiesLendingType3Choice.Proprietary))]
    #endif
    [IsoId("_9FMogMkbEeeiAIB1i4AlQw")]
    [DisplayName("Securities Lending Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesLendingType3Choice_
    #else
    public abstract partial class SecuritiesLendingType3Choice_
    #endif
    {
    }
}
