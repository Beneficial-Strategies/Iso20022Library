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
    /// Information used to identify a cash clearing system.
    /// </summary>
    [KnownType(typeof(SystemIdentification2Choice.MarketInfrastructureIdentification))]
    [KnownType(typeof(SystemIdentification2Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemIdentification2Choice.MarketInfrastructureIdentification),nameof(SystemIdentification2Choice.MarketInfrastructureIdentification))]
    [JsonDerivedType(typeof(SystemIdentification2Choice.Country),nameof(SystemIdentification2Choice.Country))]
    #endif
    [IsoId("_8BZ3QaMgEeCJ6YNENx4h-w_-1347709917")]
    [DisplayName("System Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemIdentification2Choice_
    #else
    public abstract partial class SystemIdentification2Choice_
    #endif
    {
    }
}
