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
    /// Specifies the nature of the relationship a member has with a system.
    /// </summary>
    [KnownType(typeof(SystemMemberType1Choice.Code))]
    [KnownType(typeof(SystemMemberType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemMemberType1Choice.Code),nameof(SystemMemberType1Choice.Code))]
    [JsonDerivedType(typeof(SystemMemberType1Choice.Proprietary),nameof(SystemMemberType1Choice.Proprietary))]
    #endif
    [IsoId("_Sr86gHhgEeidzqjNEfehPg")]
    [DisplayName("System Member Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemMemberType1Choice_
    #else
    public abstract partial class SystemMemberType1Choice_
    #endif
    {
    }
}
