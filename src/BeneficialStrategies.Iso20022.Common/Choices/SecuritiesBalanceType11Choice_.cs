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
    [KnownType(typeof(SecuritiesBalanceType11Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesBalanceType11Choice.Code),nameof(SecuritiesBalanceType11Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType11Choice.Proprietary),nameof(SecuritiesBalanceType11Choice.Proprietary))]
    #endif
    [IsoId("_5SHcZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Balance Type 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType11Choice_
    #else
    public abstract partial class SecuritiesBalanceType11Choice_
    #endif
    {
    }
}
