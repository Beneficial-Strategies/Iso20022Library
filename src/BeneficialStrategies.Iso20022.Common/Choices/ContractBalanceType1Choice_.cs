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
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(ContractBalanceType1Choice.Code))]
    [KnownType(typeof(ContractBalanceType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ContractBalanceType1Choice.Code),nameof(ContractBalanceType1Choice.Code))]
    [JsonDerivedType(typeof(ContractBalanceType1Choice.Proprietary),nameof(ContractBalanceType1Choice.Proprietary))]
    #endif
    [IsoId("_ntL44QtKEeWkxvNyFrBT8Q")]
    [DisplayName("Contract Balance Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractBalanceType1Choice_
    #else
    public abstract partial class ContractBalanceType1Choice_
    #endif
    {
    }
}
