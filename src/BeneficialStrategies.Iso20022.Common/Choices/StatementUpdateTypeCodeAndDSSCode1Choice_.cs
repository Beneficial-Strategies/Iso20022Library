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
    /// Choice between formats for the update type.
    /// </summary>
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode))]
    [KnownType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode),nameof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsCode))]
    [JsonDerivedType(typeof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS),nameof(StatementUpdateTypeCodeAndDSSCode1Choice.StatementUpdateTypeAsDSS))]
    #endif
    [IsoId("_sFNQkQaUEe2-DuDrUXkg2w")]
    [DisplayName("Statement Update Type Code And DSS Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementUpdateTypeCodeAndDSSCode1Choice_
    #else
    public abstract partial class StatementUpdateTypeCodeAndDSSCode1Choice_
    #endif
    {
    }
}
