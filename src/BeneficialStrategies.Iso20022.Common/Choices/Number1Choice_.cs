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
    /// Choice of format for the number.
    /// </summary>
    [KnownType(typeof(Number1Choice.NumberIdentification))]
    [KnownType(typeof(Number1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Number1Choice.NumberIdentification),nameof(Number1Choice.NumberIdentification))]
    [JsonDerivedType(typeof(Number1Choice.Proprietary),nameof(Number1Choice.Proprietary))]
    #endif
    [IsoId("_RdKfk9p-Ed-ak6NoX_4Aeg_2132216817")]
    [DisplayName("Number 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number1Choice_
    #else
    public abstract partial class Number1Choice_
    #endif
    {
    }
}
