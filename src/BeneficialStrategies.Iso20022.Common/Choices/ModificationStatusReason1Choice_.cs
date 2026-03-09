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
    /// Specifies the reason for the transaction modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatusReason1Choice.Code))]
    [KnownType(typeof(ModificationStatusReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationStatusReason1Choice.Code),nameof(ModificationStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(ModificationStatusReason1Choice.Proprietary),nameof(ModificationStatusReason1Choice.Proprietary))]
    #endif
    [IsoId("_L89WiYlsEeePr-EGJjGYzQ")]
    [DisplayName("Modification Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationStatusReason1Choice_
    #else
    public abstract partial class ModificationStatusReason1Choice_
    #endif
    {
    }
}
