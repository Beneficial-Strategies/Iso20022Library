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
    /// Specifies the status of a member within a system.
    /// </summary>
    [KnownType(typeof(SystemMemberStatus1Choice.Code))]
    [KnownType(typeof(SystemMemberStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemMemberStatus1Choice.Code),nameof(SystemMemberStatus1Choice.Code))]
    [JsonDerivedType(typeof(SystemMemberStatus1Choice.Proprietary),nameof(SystemMemberStatus1Choice.Proprietary))]
    #endif
    [IsoId("_V4OMw3hhEeidzqjNEfehPg")]
    [DisplayName("System Member Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemMemberStatus1Choice_
    #else
    public abstract partial class SystemMemberStatus1Choice_
    #endif
    {
    }
}
