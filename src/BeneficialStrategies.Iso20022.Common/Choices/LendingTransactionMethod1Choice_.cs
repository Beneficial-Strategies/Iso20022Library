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
    /// Choice of format method applied to a lending transaction.
    /// </summary>
    [KnownType(typeof(LendingTransactionMethod1Choice.Code))]
    [KnownType(typeof(LendingTransactionMethod1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LendingTransactionMethod1Choice.Code),nameof(LendingTransactionMethod1Choice.Code))]
    [JsonDerivedType(typeof(LendingTransactionMethod1Choice.Proprietary),nameof(LendingTransactionMethod1Choice.Proprietary))]
    #endif
    [IsoId("_AXB1YNokEeC60axPepSq7g_713665433")]
    [DisplayName("Lending Transaction Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LendingTransactionMethod1Choice_
    #else
    public abstract partial class LendingTransactionMethod1Choice_
    #endif
    {
    }
}
