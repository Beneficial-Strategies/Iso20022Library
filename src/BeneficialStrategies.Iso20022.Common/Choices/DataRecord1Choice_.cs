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
    /// Contains the data record in either Binary or text format.
    /// </summary>
    [KnownType(typeof(DataRecord1Choice.Binary))]
    [KnownType(typeof(DataRecord1Choice.Text))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DataRecord1Choice.Binary),nameof(DataRecord1Choice.Binary))]
    [JsonDerivedType(typeof(DataRecord1Choice.Text),nameof(DataRecord1Choice.Text))]
    #endif
    [IsoId("_Gl7WgJb8Eeuc6pwKtqbEVQ")]
    [DisplayName("Data Record 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DataRecord1Choice_
    #else
    public abstract partial class DataRecord1Choice_
    #endif
    {
    }
}
