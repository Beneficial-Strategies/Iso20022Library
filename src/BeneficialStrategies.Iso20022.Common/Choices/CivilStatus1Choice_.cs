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
    /// Choice of formats for the civil status.
    /// </summary>
    [KnownType(typeof(CivilStatus1Choice.Code))]
    [KnownType(typeof(CivilStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CivilStatus1Choice.Code),nameof(CivilStatus1Choice.Code))]
    [JsonDerivedType(typeof(CivilStatus1Choice.Proprietary),nameof(CivilStatus1Choice.Proprietary))]
    #endif
    [IsoId("_zKj4MCCgEeWJd9HF2tO7BA")]
    [DisplayName("Civil Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CivilStatus1Choice_
    #else
    public abstract partial class CivilStatus1Choice_
    #endif
    {
    }
}
