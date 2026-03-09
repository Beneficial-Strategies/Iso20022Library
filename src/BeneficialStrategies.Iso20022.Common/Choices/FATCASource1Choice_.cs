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
    /// Choice of formats for the source of the Foreign Account Tax Compliance Act (FATCA).
    /// </summary>
    [KnownType(typeof(FATCASource1Choice.Code))]
    [KnownType(typeof(FATCASource1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FATCASource1Choice.Code),nameof(FATCASource1Choice.Code))]
    [JsonDerivedType(typeof(FATCASource1Choice.Proprietary),nameof(FATCASource1Choice.Proprietary))]
    #endif
    [IsoId("_jR2x4QjUEeS5F6qHcKOrew")]
    [DisplayName("FATCA Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FATCASource1Choice_
    #else
    public abstract partial class FATCASource1Choice_
    #endif
    {
    }
}
