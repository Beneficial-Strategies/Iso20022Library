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
    /// Specifies the reason for the payment compensation.
    /// </summary>
    [KnownType(typeof(CompensationReason1Choice.Code))]
    [KnownType(typeof(CompensationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CompensationReason1Choice.Code),nameof(CompensationReason1Choice.Code))]
    [JsonDerivedType(typeof(CompensationReason1Choice.Proprietary),nameof(CompensationReason1Choice.Proprietary))]
    #endif
    [IsoId("_UyHYkIjYEeeDW7_wB-eK_g")]
    [DisplayName("Compensation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CompensationReason1Choice_
    #else
    public abstract partial class CompensationReason1Choice_
    #endif
    {
    }
}
