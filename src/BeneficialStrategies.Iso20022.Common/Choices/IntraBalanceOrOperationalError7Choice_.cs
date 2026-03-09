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
    [KnownType(typeof(IntraBalanceOrOperationalError7Choice.Movements))]
    [KnownType(typeof(IntraBalanceOrOperationalError7Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError7Choice.Movements),nameof(IntraBalanceOrOperationalError7Choice.Movements))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError7Choice.OperationalError),nameof(IntraBalanceOrOperationalError7Choice.OperationalError))]
    #endif
    [IsoId("_X3ej8TneEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraBalanceOrOperationalError7Choice_
    #else
    public abstract partial class IntraBalanceOrOperationalError7Choice_
    #endif
    {
    }
}
