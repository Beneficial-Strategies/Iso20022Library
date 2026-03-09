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
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError7Choice.Report))]
    [KnownType(typeof(StandingOrderOrError7Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingOrderOrError7Choice.Report),nameof(StandingOrderOrError7Choice.Report))]
    [JsonDerivedType(typeof(StandingOrderOrError7Choice.OperationalError),nameof(StandingOrderOrError7Choice.OperationalError))]
    #endif
    [IsoId("_eZL10dcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or Error 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrError7Choice_
    #else
    public abstract partial class StandingOrderOrError7Choice_
    #endif
    {
    }
}
