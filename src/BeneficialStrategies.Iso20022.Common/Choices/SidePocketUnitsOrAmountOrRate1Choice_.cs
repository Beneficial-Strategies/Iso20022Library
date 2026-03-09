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
    /// Choice of side pocket units, or amount, or rate.
    /// </summary>
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber))]
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount))]
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber),nameof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber))]
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount),nameof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount))]
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate),nameof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate))]
    #endif
    [IsoId("_Rhe-4dp-Ed-ak6NoX_4Aeg_-1345719140")]
    [DisplayName("Side Pocket Units Or Amount Or Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SidePocketUnitsOrAmountOrRate1Choice_
    #else
    public abstract partial class SidePocketUnitsOrAmountOrRate1Choice_
    #endif
    {
    }
}
