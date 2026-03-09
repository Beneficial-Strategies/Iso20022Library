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
    /// Specifies the type of collateral instruction.
    /// </summary>
    [KnownType(typeof(CollateralTransactionType1Choice.Code))]
    [KnownType(typeof(CollateralTransactionType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralTransactionType1Choice.Code),nameof(CollateralTransactionType1Choice.Code))]
    [JsonDerivedType(typeof(CollateralTransactionType1Choice.Proprietary),nameof(CollateralTransactionType1Choice.Proprietary))]
    #endif
    [IsoId("_NmCJ0LwdEeivTd4NUfCi2g")]
    [DisplayName("Collateral Transaction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralTransactionType1Choice_
    #else
    public abstract partial class CollateralTransactionType1Choice_
    #endif
    {
    }
}
