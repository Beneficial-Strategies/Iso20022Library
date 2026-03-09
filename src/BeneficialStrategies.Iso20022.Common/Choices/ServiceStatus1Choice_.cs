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
    /// Provides detailed information on the service request status.
    /// </summary>
    [KnownType(typeof(ServiceStatus1Choice.Code))]
    [KnownType(typeof(ServiceStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ServiceStatus1Choice.Code),nameof(ServiceStatus1Choice.Code))]
    [JsonDerivedType(typeof(ServiceStatus1Choice.Proprietary),nameof(ServiceStatus1Choice.Proprietary))]
    #endif
    [IsoId("_z_f3DfDXEemsS_0xy2XRug")]
    [DisplayName("Service Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ServiceStatus1Choice_
    #else
    public abstract partial class ServiceStatus1Choice_
    #endif
    {
    }
}
