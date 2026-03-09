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
    /// Choice of formats for the charge basis.
    /// </summary>
    [KnownType(typeof(ChargeBasisType1Choice.Code))]
    [KnownType(typeof(ChargeBasisType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeBasisType1Choice.Code),nameof(ChargeBasisType1Choice.Code))]
    [JsonDerivedType(typeof(ChargeBasisType1Choice.Proprietary),nameof(ChargeBasisType1Choice.Proprietary))]
    #endif
    [IsoId("_2HEJAWZ5EeSQMqOS_ceSQA")]
    [DisplayName("Charge Basis Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeBasisType1Choice_
    #else
    public abstract partial class ChargeBasisType1Choice_
    #endif
    {
    }
}
