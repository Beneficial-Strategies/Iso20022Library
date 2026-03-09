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
    /// Choice of format for the date.
    /// </summary>
    [KnownType(typeof(DateCode1Choice.Code))]
    [KnownType(typeof(DateCode1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateCode1Choice.Code),nameof(DateCode1Choice.Code))]
    [JsonDerivedType(typeof(DateCode1Choice.Proprietary),nameof(DateCode1Choice.Proprietary))]
    #endif
    [IsoId("_Quh399p-Ed-ak6NoX_4Aeg_-2023072430")]
    [DisplayName("Date Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode1Choice_
    #else
    public abstract partial class DateCode1Choice_
    #endif
    {
    }
}
