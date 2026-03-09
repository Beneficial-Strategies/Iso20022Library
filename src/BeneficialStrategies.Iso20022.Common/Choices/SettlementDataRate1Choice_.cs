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
    /// Specifies the volume and value percentage rates of settlement instructions.
    /// </summary>
    [KnownType(typeof(SettlementDataRate1Choice.NumberOfInstructions))]
    [KnownType(typeof(SettlementDataRate1Choice.ValueOfInstructions))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDataRate1Choice.NumberOfInstructions),nameof(SettlementDataRate1Choice.NumberOfInstructions))]
    [JsonDerivedType(typeof(SettlementDataRate1Choice.ValueOfInstructions),nameof(SettlementDataRate1Choice.ValueOfInstructions))]
    #endif
    [IsoId("_yFQMA8s0EemSav3hRKzWyg")]
    [DisplayName("Settlement Data Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDataRate1Choice_
    #else
    public abstract partial class SettlementDataRate1Choice_
    #endif
    {
    }
}
