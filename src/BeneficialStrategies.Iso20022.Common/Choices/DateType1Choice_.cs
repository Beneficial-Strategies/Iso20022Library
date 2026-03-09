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
    /// Choice between a code and or a data source scheme to determine the settlement date.
    /// </summary>
    [KnownType(typeof(DateType1Choice.Code))]
    [KnownType(typeof(DateType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateType1Choice.Code),nameof(DateType1Choice.Code))]
    [JsonDerivedType(typeof(DateType1Choice.Proprietary),nameof(DateType1Choice.Proprietary))]
    #endif
    [IsoId("_Q-6dU9p-Ed-ak6NoX_4Aeg_1965888715")]
    [DisplayName("Date Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateType1Choice_
    #else
    public abstract partial class DateType1Choice_
    #endif
    {
    }
}
