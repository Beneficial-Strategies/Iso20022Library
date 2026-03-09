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
    [KnownType(typeof(IntraBalanceOrOperationalError9Choice.Cancellations))]
    [KnownType(typeof(IntraBalanceOrOperationalError9Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError9Choice.Cancellations),nameof(IntraBalanceOrOperationalError9Choice.Cancellations))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError9Choice.OperationalError),nameof(IntraBalanceOrOperationalError9Choice.OperationalError))]
    #endif
    [IsoId("_p0siMTnfEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraBalanceOrOperationalError9Choice_
    #else
    public abstract partial class IntraBalanceOrOperationalError9Choice_
    #endif
    {
    }
}
