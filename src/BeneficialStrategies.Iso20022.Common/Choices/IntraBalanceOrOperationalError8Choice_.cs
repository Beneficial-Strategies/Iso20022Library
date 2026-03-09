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
    /// Choice between the report data or an operational error.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError8Choice.Modifications))]
    [KnownType(typeof(IntraBalanceOrOperationalError8Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError8Choice.Modifications),nameof(IntraBalanceOrOperationalError8Choice.Modifications))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError8Choice.OperationalError),nameof(IntraBalanceOrOperationalError8Choice.OperationalError))]
    #endif
    [IsoId("_ZhRzuzneEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraBalanceOrOperationalError8Choice_
    #else
    public abstract partial class IntraBalanceOrOperationalError8Choice_
    #endif
    {
    }
}
