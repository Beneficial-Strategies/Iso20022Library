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
    /// Choice between a code or a data source scheme to determine a date format.
    /// </summary>
    [KnownType(typeof(Date2Choice.Code))]
    [KnownType(typeof(Date2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Date2Choice.Code),nameof(Date2Choice.Code))]
    [JsonDerivedType(typeof(Date2Choice.Proprietary),nameof(Date2Choice.Proprietary))]
    #endif
    [IsoId("_UdW4MNopEeCWg-hsBVGrDA_1543925499")]
    [DisplayName("Date 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Date2Choice_
    #else
    public abstract partial class Date2Choice_
    #endif
    {
    }
}
