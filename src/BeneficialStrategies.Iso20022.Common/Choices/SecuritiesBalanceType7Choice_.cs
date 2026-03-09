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
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType7Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesBalanceType7Choice.Code),nameof(SecuritiesBalanceType7Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType7Choice.Proprietary),nameof(SecuritiesBalanceType7Choice.Proprietary))]
    #endif
    [IsoId("_zRSCkTp7EeWVrPy0StzzSg")]
    [DisplayName("Securities Balance Type 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType7Choice_
    #else
    public abstract partial class SecuritiesBalanceType7Choice_
    #endif
    {
    }
}
