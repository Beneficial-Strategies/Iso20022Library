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
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [KnownType(typeof(QuantityNominalValue1Choice.Quantity))]
    [KnownType(typeof(QuantityNominalValue1Choice.NominalValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(QuantityNominalValue1Choice.Quantity),nameof(QuantityNominalValue1Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityNominalValue1Choice.NominalValue),nameof(QuantityNominalValue1Choice.NominalValue))]
    #endif
    [IsoId("_kXBi4HaiEeavseMKyTsJEA")]
    [DisplayName("Quantity Nominal Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityNominalValue1Choice_
    #else
    public abstract partial class QuantityNominalValue1Choice_
    #endif
    {
    }
}
