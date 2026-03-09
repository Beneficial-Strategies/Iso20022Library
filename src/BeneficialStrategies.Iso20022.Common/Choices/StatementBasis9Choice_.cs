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
    [KnownType(typeof(StatementBasis9Choice.Code))]
    [KnownType(typeof(StatementBasis9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatementBasis9Choice.Code),nameof(StatementBasis9Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis9Choice.Proprietary),nameof(StatementBasis9Choice.Proprietary))]
    #endif
    [IsoId("_5Wx6LpNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementBasis9Choice_
    #else
    public abstract partial class StatementBasis9Choice_
    #endif
    {
    }
}
