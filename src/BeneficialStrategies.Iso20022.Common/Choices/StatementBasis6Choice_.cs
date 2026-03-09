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
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis6Choice.Code))]
    [KnownType(typeof(StatementBasis6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatementBasis6Choice.Code),nameof(StatementBasis6Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis6Choice.Proprietary),nameof(StatementBasis6Choice.Proprietary))]
    #endif
    [IsoId("_nAFOcPNBEeCuA5Tr22BnwA_192317835")]
    [DisplayName("Statement Basis 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementBasis6Choice_
    #else
    public abstract partial class StatementBasis6Choice_
    #endif
    {
    }
}
