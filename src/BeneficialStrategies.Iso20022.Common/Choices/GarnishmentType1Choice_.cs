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
    /// Specifies the type of garnishment.
    /// </summary>
    [KnownType(typeof(GarnishmentType1Choice.Code))]
    [KnownType(typeof(GarnishmentType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GarnishmentType1Choice.Code),nameof(GarnishmentType1Choice.Code))]
    [JsonDerivedType(typeof(GarnishmentType1Choice.Proprietary),nameof(GarnishmentType1Choice.Proprietary))]
    #endif
    [IsoId("_k8MIkYnnEeOORMXOfBk1Bw")]
    [DisplayName("Garnishment Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GarnishmentType1Choice_
    #else
    public abstract partial class GarnishmentType1Choice_
    #endif
    {
    }
}
