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
    /// Choice between an amount or number of units.
    /// </summary>
    [KnownType(typeof(UnitsOrAmount1Choice.Amount))]
    [KnownType(typeof(UnitsOrAmount1Choice.Unit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitsOrAmount1Choice.Amount),nameof(UnitsOrAmount1Choice.Amount))]
    [JsonDerivedType(typeof(UnitsOrAmount1Choice.Unit),nameof(UnitsOrAmount1Choice.Unit))]
    #endif
    [IsoId("_Jb_o8xQcEeKebsB9eKJSkA")]
    [DisplayName("Units Or Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitsOrAmount1Choice_
    #else
    public abstract partial class UnitsOrAmount1Choice_
    #endif
    {
    }
}
